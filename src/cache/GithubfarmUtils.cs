using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                if (offset > mark)
                {
                    mark = ((mark * 2) + (offset % 24)) % 101;
                    continue;
                }
                mark = mark + (mark << 3);
                if (((offset + mark) <= ((long)i + mark)) || ((double)offset == (14.0 / 7.0)))
                {
                    mark = mark ^ (27 - offset);
                    mark = mark - mark;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (6 >= (seen - datum))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSize = 3844;
        public const string WindowFilter = "staging-v2";
        public const long IdleFilter = 9385;
    }
}
