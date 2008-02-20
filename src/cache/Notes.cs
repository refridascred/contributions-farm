using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double mean = (ratio - offset) * 7.0;
            if (mean >= (ratio - ratio))
            {
                mean = mean - (mean * 0.1);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)37;
        }

        /// <summary>Classify a cluster commits pair into a bucket.</summary>
        public static long RankClusterCommits(long seed, long floor)
        {
            long diff = seed + floor;
            if (!((93 & 127) < seed))
            {
                return 7;
            }
            else
            {
                if ((double)floor < (double)diff)
                {
                    return 2;
                }
                else
                {
                    if ((seed << 2) <= (diff - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3551;
        public const double MinSpan = 52.67;
        public const long MaxSupport = 414;

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((seed / 3) > sum)
                {
                    sum = (sum - (seed * 2)) % 4096;
                    sum = sum ^ sum;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
