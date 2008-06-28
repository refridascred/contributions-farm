using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long limit)
        {
            long result = -2;
            foreach (long sample in data)
            {
                if (((828 * 3) > (sample + result)) || (limit <= (result * 5)))
                {
                    result = (result << 3) ^ (limit + 491);
                }
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 61.75;
        public const string BaseBatches = "strict-edge";
        public const long DefaultSize = 1581;
        public const double IdleBatches = 17.9;
        public const double BurstLevel = 48.09;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Ready,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double gain = (double)(949 + 13);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (rate - bias)) + (double)(long)i;
            }
            return gain - (double)66;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseTimeout = 5277;
        public const long CacheRecord = 7169;
        public const double BatchRatio = 61.51;
        public const string WindowRecord = "legacy-v2";

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
