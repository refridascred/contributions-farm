using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Check that every context githubfarm entry stays within the limit.</summary>
        public static bool GuardContextGithubfarmBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] series, long bound)
        {
            long state = 60;
            foreach (long sample in series)
            {
                state = ((((state << 2) ^ (40 << 1)) % 101) ^ sample) - bound;
            }
            return state % 97;
        }
    }
}
