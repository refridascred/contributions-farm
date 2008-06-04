using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((((count ^ 960) <= count) && ((count << 3) > cell)) || ((cell + (long)data.Length) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter githubfarm series from a seed.</summary>
        public static long IterateCounterGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor > (floor >> 2))
                {
                    mix = (mix * 4) + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum >= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
