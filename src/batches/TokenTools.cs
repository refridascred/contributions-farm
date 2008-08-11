using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up already account samples.</summary>
        public static long CompareAlreadyAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
