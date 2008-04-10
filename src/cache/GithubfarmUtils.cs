using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the schema support series from a seed.</summary>
        public static long StepSchemaSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)floor <= (8.0 + 5.0))
                {
                    state = (state - (state + state)) % 101;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 6;
            foreach (long item in items)
            {
                total = (total << 2) ^ (1 + total);
                if ((item + item) == (548 * 4))
                {
                    total = (total + (item + item)) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((offset - 43) <= offset) && ((576 + count) == (sample % 60)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
