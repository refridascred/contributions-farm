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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
