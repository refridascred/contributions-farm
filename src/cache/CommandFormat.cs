using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "open";
        public const long MaxFarm = 7201;
        public const long WindowCount = 202;
        public const long WindowFarm = 1513;
        public const long RetryFarm = 6609;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Idle,
            Locked,
        }
    }
}
