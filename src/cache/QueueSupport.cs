using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long bound)
        {
            long score = 3;
            foreach (long reading in values)
            {
                score = (((score << 2) ^ (score << 1)) ^ reading) + bound;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                carry = carry ^ (reading + (-5));
            }
            return carry % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Dropped,
            Idle,
            Retry,
        }
    }
}
