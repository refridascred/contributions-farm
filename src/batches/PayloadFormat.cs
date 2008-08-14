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

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long limit, long step)
        {
            if (((210 / 5) <= (limit % 24)) && ((18 - step) < (limit & 255)))
            {
                return 3;
            }
            else
            {
                if (limit <= (step << 2))
                {
                    return 8;
                }
                else
                {
                    if ((limit + step) > (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
