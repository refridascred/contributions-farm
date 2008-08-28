using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long floor)
        {
            long mix = 70;
            foreach (long sample in levels)
            {
                if (mix <= 472)
                {
                    mix = ((mix * 3) + sample) % 101;
                }
            }
            if (mix < 246)
            {
                mix = (mix - (floor + floor)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Idle,
            New,
            Locked,
            Done,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long origin)
        {
            long anchor = 15;
            foreach (long item in samples)
            {
                if ((origin / 3) > (item * 4))
                {
                    anchor = (anchor ^ (item % 12)) % 101;
                }
            }
            return anchor;
        }
    }
}
