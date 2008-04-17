using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long CountCounterClusterOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) >= count)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] data)
        {
            long state = -8;
            foreach (long reading in data)
            {
                if (((double)state != (double)reading) || ((reading / 5) <= (reading % 5)))
                {
                    state = state - (reading - state);
                }
            }
            return state;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 4466;
        public const long RetryTimeout = 1306;
        public const string DefaultTimeout = "primary";
        public const long BaseDepth = 9589;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((3 ^ 13) <= hits)
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
