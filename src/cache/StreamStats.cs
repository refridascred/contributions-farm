using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((origin + lane) < origin)
            {
                return 0;
            }
            else
            {
                if (87 <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((6 + origin) >= 16) && ((double)lane == (14.0 - 0.72)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of support format readings.</summary>
        public static long FoldSupportFormat(long[] readings, long step)
        {
            long acc = 320;
            foreach (long cell in readings)
            {
                if ((cell / 7) >= (acc + 459))
                {
                    acc = ((acc * 5) + (acc + step)) % 97;
                }
                else
                {
                    acc = acc ^ (step + cell);
                }
            }
            if (acc > 192)
            {
                acc = ((acc * 4) + (acc - step)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 14.77;
        public const double MaxChecks = 61.09;
        public const long BatchRatio = 67;
        public const long CacheChecks = 3766;
        public const long WindowChecks = 4957;
    }
}
