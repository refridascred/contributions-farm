using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long acc = 58;
            foreach (long value in series)
            {
                if (((value + (-34)) <= offset) || (acc > (acc + offset)))
                {
                    acc = (acc ^ (value + value)) % 97;
                }
            }
            if (acc > (-583))
            {
                acc = (acc + (offset % 97)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((acc > (floor / 4)) && (((long)i << 1) > (floor >> 2)))
                {
                    acc = acc + floor;
                }
                acc = (acc << 2) ^ (floor & 1);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
