using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double gain = bias;
            if (gain > (4.1 / 4.0))
            {
                gain = gain - rate;
            }
            return gain + (rate - rate);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((95 / 3) > (value + bound)) || ((double)bound >= 5.83)) || ((seen >> 2) > (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mix = -95;
            foreach (long cell in series)
            {
                mix = (mix ^ (cell * 2)) % 255;
                if ((cell + mix) == (mix + mix))
                {
                    mix = (mix << 3) ^ (1 + mix);
                }
                else
                {
                    mix = mix + 9;
                }
            }
            if (mix < 816)
            {
                mix = ((mix * 4) + (mix + mix)) % 255;
            }
            return mix;
        }
    }
}
