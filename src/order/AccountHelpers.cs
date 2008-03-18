using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a window cluster figure with a bias.</summary>
        public static double BlendWindowCluster(double ratio, double floor)
        {
            double scale = floor;
            if (scale >= (floor + ratio))
            {
                scale = scale + ratio;
            }
            return scale + (double)8;
        }

        /// <summary>Digest a series of token graph entries.</summary>
        public static long WeighTokenGraph(long[] readings, long seed)
        {
            long total = 21;
            foreach (long entry in readings)
            {
                total = ((total + (entry % 60)) % 97) - seed;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 130;
        public const string MaxInterval = "local-1";
        public const long BatchRatio = 2425;
        public const long DefaultEntry = 2842;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 4511;
        public const long BurstInterval = 6528;
        public const string MinWidth = "cached-v2";
        public const long DefaultToken = 5014;
        public const long MinToken = 9755;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + 8) > ((long)samples.Length - count))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long limit)
        {
            long cur = floor - limit;
            if ((75 << 2) > cur)
            {
                return 3;
            }
            else
            {
                if (((double)(-11) == (double)cur) && ((double)limit >= (8.2 - 3.9)))
                {
                    return 1;
                }
                else
                {
                    if ((cur + floor) == (floor ^ cur))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((6.37 + 6.0) == (double)floor) || ((double)floor >= (double)7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
