using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - sum) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum + 534) % 65521) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state << 3) ^ (state << 3)) % 4096;
                if ((state << 3) <= step)
                {
                    state = state - (long)i;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
