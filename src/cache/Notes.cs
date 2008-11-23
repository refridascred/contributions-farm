using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((-9) >= (reading / 4))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm farm readings.</summary>
        public static long CombineGithubfarmFarm(long[] values, long seed)
        {
            long mark = 311;
            foreach (long reading in values)
            {
                if (((mark + reading) == (1 % 60)) || (1 < (mark >> 4)))
                {
                    mark = (mark ^ (mark % 16)) % 97;
                }
                else
                {
                    mark = (mark << 2) ^ (seed / 5);
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepWidth = 6407;
        public const long LimitSchema = 5687;
        public const long MaxFactor = 4306;
        public const double LimitLevel = 28.0;
    }
}
