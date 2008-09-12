using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitWidth = 3557;
        public const long RetryChannel = 8080;
        public const long BatchChannel = 9930;
    }
}
