using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of checks window readings.</summary>
        public static long FoldChecksWindow(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = (total * 3) + (724 - reading);
                if (!((total * 5) <= (total / 7)))
                {
                    total = (total - (reading + total)) % 255;
                }
                else
                {
                    total = (total ^ 972) % 65521;
                }
                if ((double)964 > (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double weight = (double)(3 << 3);
            if (weight <= (bias + bias))
            {
                weight = weight + (weight * 1.53);
            }
            return weight - (3.6 - gain);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 5;
            foreach (long value in series)
            {
                mix = ((mix ^ 54) % 101) - value;
            }
            return mix;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheLevel = 1155;
        public const long RetryGraph = 8819;
        public const long LimitGraph = 3583;
    }
}
