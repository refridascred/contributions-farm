using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long step)
        {
            long total = 988;
            foreach (long entry in data)
            {
                if (entry >= (entry - total))
                {
                    total = total ^ step;
                }
                if ((0 & 127) >= step)
                {
                    total = (total - total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of batch farm readings.</summary>
        public static long PairBatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepDepth = "cached-1";
        public const long BatchEditor = 4127;
        public const long LimitWidth = 6243;
        public const long StepLevel = 9343;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultLevel = 1;
        public const string WindowRecord = "alpha-edge";
        public const long StepCount = 8545;
    }
}
