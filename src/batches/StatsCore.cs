using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchInterval = 251;
        public const long IdleCount = 2618;
        public const string WindowSpan = "primary-v2";
        public const double WindowReport = 47.36;
        public const long RetryReport = 6085;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowWidth = 6531;
        public const string MaxTools = "local-1";
        public const long LimitTools = 2092;
        public const long RetryDepth = 7431;

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.49;
        public const long BatchCommits = 6265;
        public const long MinCommits = 9575;

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double offset)
        {
            double rate2 = rate + (rate - rate);
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 - rate2) - (double)(long)i) + offset;
            }
            return rate2 + (8.74 * 0.1);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((7 ^ seed) > seed) && ((datum >> 1) <= seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
