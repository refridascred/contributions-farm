using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = (total ^ 79) % 101;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
