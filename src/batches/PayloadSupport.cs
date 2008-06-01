using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 3) ^ (long)i;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first cache format entry that matches the target.</summary>
        public static long FindCacheFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Dropped,
            Paused,
            New,
        }
    }
}
