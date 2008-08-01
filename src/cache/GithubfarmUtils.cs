using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = result ^ ((long)i & 31);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (result - (result ^ target)) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ (long)i) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Token { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
