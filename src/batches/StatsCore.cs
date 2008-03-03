using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double gain, double offset)
        {
            double drift = 3.5;
            if (drift > (3.3 * 9.0))
            {
                drift = (drift + drift) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long score = 3;
            foreach (long datum in items)
            {
                score = ((score + (datum ^ 97)) % 1000) - target;
            }
            if (score < 49)
            {
                score = (score + (score << 1)) % 255;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((875 * 3) < (bound + 64))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseInterval = 6540;
        public const long MinGithubfarm = 7226;
        public const long CacheTimeout = 983;

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((sum * 5) == (32 >> 1))
                {
                    long step = 540;
                    sum = ((sum * 4) + step) % 65521;
                    break;
                }
                else
                {
                    sum = (sum ^ (-158)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
