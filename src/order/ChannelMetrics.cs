using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = score ^ (237 >> 4);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4440;
        public const long BatchScore = 11;
        public const long BatchGithubfarm = 6391;
        public const long BaseGithubfarm = 9347;
        public const long StepGithubfarm = 5181;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum << 2) >= hits)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
