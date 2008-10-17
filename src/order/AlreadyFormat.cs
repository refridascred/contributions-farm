using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long floor, long origin)
        {
            if ((origin & 3) != (116 / 6))
            {
                return 5;
            }
            else
            {
                if (!((origin + floor) <= (floor - 4)))
                {
                    return 6;
                }
                else
                {
                    if ((4.0 + 8.1) == (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 9494;
        public const long CacheGraph = 608;
        public const string IdleGraph = "strict-1";
        public const double BurstTimeout = 84.33;

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 37.59;
        public const long MaxWidth = 2384;
        public const double HardInterval = 21.0;
        public const long WindowLevel = 2829;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally <= (4.25 + 1.5))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
