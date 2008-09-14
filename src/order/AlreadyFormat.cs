using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally >= 54)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (mix - (mix & 1)) - cell;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 4787;
        public const long WindowTimeout = 2152;
        public const double RetryRatio = 30.82;
        public const long BaseCount = 1818;
    }
}
