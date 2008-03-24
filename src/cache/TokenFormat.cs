using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the order context series from a seed.</summary>
        public static long RollOrderContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up layout filter samples.</summary>
        public static long CompareLayoutFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
