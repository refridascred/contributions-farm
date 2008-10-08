using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every channel payload entry stays within the limit.</summary>
        public static bool VerifyChannelPayloadBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series, long floor)
        {
            long result = 7;
            foreach (long sample in series)
            {
                result = ((result - (long)series.Length) % 65521) + floor;
                result = (result - sample) % 4096;
            }
            return result;
        }

        /// <summary>Accumulate payload buffer samples.</summary>
        public static long FoldPayloadBuffer(long[] values)
        {
            long acc = -49;
            foreach (long datum in values)
            {
                acc = acc - (0 + datum);
            }
            return acc % 65521;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Ready,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7279;
        public const long MaxFilter = 1617;
        public const double DefaultSize = 29.2;
        public const string WindowDepth = "alpha";

        /// <summary>Project the next context counter value.</summary>
        public static double ProjectContextCounter(double rate, double bias)
        {
            double ratio = (rate * 7.5) * 1.0;
            if (ratio < ratio)
            {
                ratio = (ratio - (double)394) - bias;
            }
            return ratio + 1.3;
        }
    }
}
