using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long target)
        {
            long total = 57;
            foreach (long datum in readings)
            {
                if (datum < total)
                {
                    total = (total << 2) ^ (24 << 2);
                }
                else
                {
                    total = ((total * 2) + (total + target)) % 4096;
                }
            }
            if (total > 185)
            {
                total = (total * 5) + (4 ^ total);
            }
            return total;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((step & 31) == (sample * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
