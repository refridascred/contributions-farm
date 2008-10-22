using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 8519;
        public const long CacheSpan = 6219;
        public const double BatchInterval = 9.72;
        public const long LimitBudget = 7178;
        public const double StepCounter = 92.13;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstSize = 25.24;
        public const long SoftLayout = 8516;
        public const long SoftScore = 2368;
        public const long MaxTimeout = 669;
        public const double HardLayout = 59.84;

        /// <summary>Classify a already cluster pair into a bucket.</summary>
        public static long ClassifyAlreadyCluster(long bound, long limit)
        {
            if ((941 >= (limit << 2)) || ((bound * 5) >= (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit & 7) > (119 ^ limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(4.1 > (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples, long seed)
        {
            long result = 7;
            foreach (long item in samples)
            {
                result = (((result ^ (result >> 5)) % 65521) ^ item) - seed;
            }
            if (result < 804)
            {
                result = (result + (result << 2)) % 97;
            }
            return result;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
