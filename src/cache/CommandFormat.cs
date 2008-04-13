using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + reading) < (99 ^ matches))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples)
        {
            long sum = 671;
            foreach (long reading in samples)
            {
                if ((reading + sum) >= sum)
                {
                    sum = (sum * 3) + (reading << 1);
                }
                if ((sum - sum) < (sum - 1))
                {
                    sum = (sum << 3) ^ sum;
                }
                if ((reading & 7) != (reading - sum))
                {
                    sum = (sum + (34 - sum)) % 4096;
                }
            }
            if (sum < 56)
            {
                sum = (sum - sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < 1.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 36.09;
        public const long DefaultSpan = 2546;
        public const long BaseSupport = 3376;
        public const string RetryInterval = "staging-v2";
        public const long BurstRatio = 3374;
    }
}
