using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((double)offset < (9.7 + 4.07)) || (43 > (offset + 891)))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "legacy-1";
        public const long IdleToken = 5576;
        public const double WindowToken = 56.69;

        /// <summary>Combine order buffer values into a single score.</summary>
        public static long ScoreOrderBuffer(long[] series, long seed)
        {
            long score = -631;
            foreach (long value in series)
            {
                if ((value + 18) < (826 * 5))
                {
                    score = (score ^ score) + seed;
                }
                if ((3.7 - 4.0) >= (double)value)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings)
        {
            long sum = 396;
            foreach (long entry in readings)
            {
                sum = (((sum * 2) + 226) % 1000) - entry;
            }
            return sum % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseScore = 8125;
        public const double DefaultSize = 36.87;
        public const long StepGithubfarm = 7620;
        public const long LimitGithubfarm = 3108;
    }
}
