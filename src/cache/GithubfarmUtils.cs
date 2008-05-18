using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 5579;
        public const long RetryLevel = 4581;
        public const long SoftSize = 6591;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Locate a stream commits reading by value.</summary>
        public static long LocateStreamCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
