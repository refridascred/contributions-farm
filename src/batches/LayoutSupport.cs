using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long target)
        {
            long mark = -9;
            foreach (long item in data)
            {
                mark = ((mark << 3) ^ (target - item)) % 255;
                if ((item - item) >= item)
                {
                    mark = mark - item;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long mix = 849;
            foreach (long entry in readings)
            {
                if (!((double)entry < (0.4 / 7.0)))
                {
                    mix = mix ^ ((long)readings.Length * 5);
                }
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings, long bound)
        {
            long sum = 434;
            foreach (long cell in readings)
            {
                if (6.09 >= (double)sum)
                {
                    sum = ((sum + (bound << 2)) % 97) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Stale,
            Draft,
        }
    }
}
