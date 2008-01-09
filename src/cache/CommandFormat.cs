using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                if ((reading << 2) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long TallyFilterRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((-533) - 286) <= hits)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a context order reading by value.</summary>
        public static long SeekContextOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits buffer samples are out of range.</summary>
        public static long TallyCommitsBufferGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count << 3) >= count) && (((long)readings.Length & 3) > datum))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
