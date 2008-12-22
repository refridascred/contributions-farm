using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long origin, long step)
        {
            if ((double)origin > (9.0 - 6.1))
            {
                return 4;
            }
            else
            {
                if ((9.0 - 5.0) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 81.84;
        public const string DefaultInterval = "alpha-v2";
        public const string BatchInterval = "primary-1";
        public const long HardReport = 2970;
        public const long BurstReport = 580;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Pending,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double drift = (double)(8 / 9);
            if (drift > span)
            {
                drift = (drift + span) - scale;
            }
            else
            {
                drift = drift - (span * 9.39);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 7.3) + (double)(long)i;
            }
            return drift - (double)16;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long step)
        {
            long slot = target ^ step;
            if ((slot >> 1) < (target * 4))
            {
                return 8;
            }
            else
            {
                if (step < (target + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
