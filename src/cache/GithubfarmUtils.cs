using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a command session counter forward.</summary>
        public static long DeriveCommandSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((double)bound < (1.1 - 1.18)) && ((state % 3) < bound))
                {
                    state = (state * 5) + ((long)i - state);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
