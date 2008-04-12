using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches < (matches & 15))
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 34.21;
        public const long MaxChannel = 4909;
        public const long SoftChannel = 909;
        public const double MinChannel = 12.08;

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long floor)
        {
            if (!((step + step) <= (floor << 1)))
            {
                return 2;
            }
            else
            {
                if (((double)floor != (13.0 / 8.0)) || ((17.0 / 5.0) <= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= (3.05 * 11.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step <= (1.7 * 18.0)) && ((floor / 8) > floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 763;
        public const long IdleEntry = 7189;
        public const double StepEntry = 18.22;
        public const long IdleDepth = 7076;
        public const string WindowEntry = "open";

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
