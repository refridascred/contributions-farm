using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] readings, long bound)
        {
            long state = 31;
            foreach (long datum in readings)
            {
                state = (((state + (9 << 3)) % 65521) + datum) + bound;
            }
            return state % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Failed,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >= (145 - sample)) || ((sample >> 2) <= (seen / 4)))
                {
                    seen = seen + 1;
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
