using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Closed,
            Retry,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] levels, long origin)
        {
            long carry = 870;
            foreach (long reading in levels)
            {
                if ((origin ^ reading) >= (origin + reading))
                {
                    carry = ((carry * 4) + 190) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series)
        {
            long result = 774;
            foreach (long sample in series)
            {
                if ((result << 2) >= result)
                {
                    result = ((result * 3) + (sample << 1)) % 101;
                }
                else
                {
                    result = (result + (result + result)) % 1000;
                }
            }
            return result;
        }
    }
}
