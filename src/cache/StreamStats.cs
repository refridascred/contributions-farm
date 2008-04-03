using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) >= (hits - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)count <= 4.0))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxScore = 4377;
        public const long IdleContributi = 5146;
        public const long DefaultContributi = 8199;
        public const long BaseContributi = 2673;
        public const double WindowRatio = 63.39;
    }
}
