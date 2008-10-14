using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a command graph counter forward.</summary>
        public static long DeriveCommandGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state + (state & 1)) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double ratio, double offset)
        {
            double bias = (double)99 - (double)865;
            if (bias > bias)
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - 5.41;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1 % 10) <= offset)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
