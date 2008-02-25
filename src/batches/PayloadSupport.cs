using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate schema githubfarm samples.</summary>
        public static long TotalSchemaGithubfarm(long[] series)
        {
            long state = 671;
            foreach (long entry in series)
            {
                if ((double)entry >= (7.0 * 6.0))
                {
                    state = (state << 2) ^ (state - entry);
                }
                else
                {
                    state = ((state << 2) ^ (state % 60)) % 255;
                }
                if (((entry << 3) >= 958) || (state > (entry * 2)))
                {
                    break;
                }
            }
            if (state < 896)
            {
                state = ((state * 2) + (state % 100)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
