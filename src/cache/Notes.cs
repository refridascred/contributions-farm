using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (((slot + slot) >= (bound << 1)) && ((double)seed < (double)0))
            {
                return 7;
            }
            else
            {
                if (((bound + 31) < (bound << 1)) || ((double)seed > (5.0 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (limit >= (5 + count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell & 1) > (cell % 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
