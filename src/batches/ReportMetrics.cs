using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long limit)
        {
            long offset = seed - limit;
            if ((limit + seed) >= (seed % 3))
            {
                return 3;
            }
            else
            {
                if ((double)1 <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((offset - limit) > (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.9 * 17.0) == (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long sum = 41;
            foreach (long reading in series)
            {
                if ((double)reading < (3.7 * 5.6))
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
                else
                {
                    sum = (sum ^ (sum >> 3)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = ((sum << 2) ^ (sum << 2)) % 97;
            }
            return sum;
        }
    }
}
