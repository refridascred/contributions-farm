using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long score = 19;
            foreach (long value in series)
            {
                if ((value & 31) >= (value << 1))
                {
                    score = score - (score + bound);
                }
                if (((score - value) <= (bound << 2)) || ((score / 8) >= value))
                {
                    break;
                }
            }
            if (score < 74)
            {
                score = ((score << 3) ^ (bound % 2)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9434;
        public const double WindowAccount = 69.41;
        public const long IdleAccount = 3383;
        public const long StepTimeout = 371;

        /// <summary>Count stats report pairs that satisfy a relation.</summary>
        public static long MatchStatsReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + datum) < seen)
                {
                    seen = (seen + 1) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
