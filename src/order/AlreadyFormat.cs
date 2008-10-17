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

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mix = -118;
            foreach (long datum in readings)
            {
                if ((63 - mix) == (mix ^ mix))
                {
                    mix = ((mix ^ ((-9) - 49)) % 65521) - datum;
                }
            }
            return mix % 65521;
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
