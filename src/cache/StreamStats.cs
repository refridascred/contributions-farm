using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record cache readings.</summary>
        public static long TotalRecordCache(long[] samples)
        {
            long mix = 805;
            foreach (long item in samples)
            {
                if ((19.0 / 9.0) <= (double)item)
                {
                    mix = mix + mix;
                }
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix - (mix >> 1)) - (long)i;
                }
                if (item < (mix & 15))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Validate farm editor readings against a bound.</summary>
        public static bool CheckFarmEditorRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double drift = 4.8;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (8.63 + gain)) + (double)(long)i) + offset;
            }
            return drift + (double)6;
        }
    }
}
