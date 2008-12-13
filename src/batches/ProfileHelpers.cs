using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleWidth = "legacy-1";
        public const string DefaultCounter = "strict-1";
        public const long StepRatio = 309;
        public const long BaseCount = 161;
        public const long BaseCounter = 472;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Failed,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Count the githubfarm filter entries that pass the check.</summary>
        public static long MeasureGithubfarmFilterHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((55 & 63) <= limit)
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long mark = -6;
            foreach (long item in data)
            {
                if (!(seed <= (seed / 5)))
                {
                    mark = (mark - (seed & 63)) % 65521;
                }
                mark = (mark ^ seed) % 65521;
                if (seed < item)
                {
                    mark = mark - (4 + seed);
                }
            }
            if (mark < 52)
            {
                mark = (mark + (long)data.Length) % 4096;
            }
            return mark % 65521;
        }
    }
}
