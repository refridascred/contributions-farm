using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string StepTimeout = "fallback-v2";
        public const double MaxBudget = 85.17;
        public const long RetryEditor = 6928;

        /// <summary>Check that every editor queue entry stays within the limit.</summary>
        public static bool VerifyEditorQueueBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] readings, long step)
        {
            long score = 59;
            foreach (long entry in readings)
            {
                score = (score ^ (step & 1)) ^ entry;
                score = (score << 2) ^ (score & 127);
            }
            if (score > (-67))
            {
                score = score - step;
            }
            return score % 97;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Queued,
        }
    }
}
