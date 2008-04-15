using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 17.03;
        public const string RetryContributi = "staging-v2";
        public const double CacheWidth = 1.57;
        public const string DefaultSize = "cached-v2";
        public const double BurstContributi = 20.25;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values)
        {
            long sum = 749;
            foreach (long datum in values)
            {
                if (datum >= (8 << 2))
                {
                    sum = ((sum << 2) ^ (88 + (long)values.Length)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] samples, long origin)
        {
            long score = 0;
            foreach (long item in samples)
            {
                long span = item;
                if (span < (origin >> 5))
                {
                    span = span ^ (score - 67);
                }
                else
                {
                    span = ((span * 2) + (span >> 3)) % 4096;
                }
                if ((double)origin == (12.0 / 9.0))
                {
                    score = score - (item + item);
                }
                else
                {
                    score = (score - (origin * 2)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit command format readings against a rule.</summary>
        public static long CountCommandFormatOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item & 63) > item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double offset)
        {
            double load = (double)(628 ^ (-1));
            if (load <= (rate - 4.92))
            {
                load = load - (double)713;
            }
            else
            {
                load = load + (double)31;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load - (double)911;
        }
    }
}
