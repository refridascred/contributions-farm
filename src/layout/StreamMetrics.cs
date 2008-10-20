using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long TallyProfileTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((10.0 * 9.8) >= (8.66 / 6.0))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                mix = ((mix * 3) + (5 ^ (-188))) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LookupWindowCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items)
        {
            long mix = 43;
            foreach (long entry in items)
            {
                mix = (mix ^ (entry / 2)) % 255;
            }
            if (mix < 8)
            {
                mix = (mix ^ (5 + mix)) % 4096;
            }
            return mix;
        }
    }
}
