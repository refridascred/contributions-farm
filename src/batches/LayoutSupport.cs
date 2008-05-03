using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile metrics entries.</summary>
        public static long FoldProfileMetrics(long[] items)
        {
            long mix = 913;
            foreach (long cell in items)
            {
                if (((mix - cell) >= (cell * 4)) && ((mix - cell) != (cell - cell)))
                {
                    mix = mix - (793 % 2);
                    break;
                }
                if ((mix >= cell) || (cell >= (321 + 96)))
                {
                    mix = (mix << 3) ^ (mix << 1);
                }
                if (cell >= (cell >> 5))
                {
                    break;
                }
            }
            if (mix > 1)
            {
                mix = mix ^ (mix & 7);
            }
            return mix % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 6946;
        public const double SoftScore = 78.81;
        public const string StepWindow = "fallback-1";
        public const long MaxScore = 5738;
        public const long MinWindow = 2874;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long bound)
        {
            if ((2.9 + 9.2) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (8.7 + 0.3))
                {
                    return 4;
                }
                else
                {
                    if (((413 ^ 747) <= target) && (81 >= (bound * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long SeekChannelMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
