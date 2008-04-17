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

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series, long bound)
        {
            long anchor = 80;
            foreach (long cell in series)
            {
                if (((bound & 1) >= ((-8) % 60)) || ((double)anchor == (double)bound))
                {
                    anchor = (anchor - (cell << 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + cell) % 65521;
                }
            }
            if (anchor > 63)
            {
                anchor = (anchor ^ (anchor - bound)) % 65521;
            }
            return anchor;
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
