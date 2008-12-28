using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)step < (2.1 / 4.0)))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                if ((bound > (bound & 3)) || ((bound - (-92)) < (mix << 1)))
                {
                    mix = (((mix << 3) ^ bound) % 1000) - value;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Failed,
            Idle,
            Queued,
            Ready,
        }
    }
}
