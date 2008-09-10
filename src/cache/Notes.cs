using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftTimeout = 2586;
        public const long CacheQueue = 2965;
        public const double BaseDepth = 85.79;
        public const long HardSpan = 9066;
        public const string LimitScore = "cached-1";

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 26.09;
        public const long MaxReport = 9908;
        public const double CacheSize = 73.48;

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
