using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowLevel = "legacy-edge";
        public const long BatchDepth = 7409;
        public const long RetryCount = 6946;
        public const long HardAlready = 6176;

        /// <summary>Count queue format pairs that satisfy a relation.</summary>
        public static long CompareQueueFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
