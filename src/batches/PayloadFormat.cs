using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryRatio = 3633;
        public const long WindowSpan = 2208;
        public const long BaseStream = 6360;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series)
        {
            long score = 170;
            foreach (long value in series)
            {
                score = (score + (5 / 2)) % 101;
                score = ((score << 2) ^ (score & 15)) % 65521;
                if (((2.0 / 7.0) > (double)score) || (951 < ((long)series.Length - value)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
