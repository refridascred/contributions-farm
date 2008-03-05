using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a token context sample.</summary>
        public static long LocateTokenContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels)
        {
            long state = 18;
            foreach (long item in levels)
            {
                state = ((state << 2) ^ (660 - 479)) + item;
                if ((13.0 * 4.51) >= (double)state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
