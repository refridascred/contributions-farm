using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 74.09;
        public const long CacheContributi = 1863;
        public const string BatchContributi = "open-edge";
        public const long HardContributi = 6117;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Stale,
            New,
            Idle,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long target)
        {
            long slot = floor - target;
            if (!(slot < 35))
            {
                return 5;
            }
            else
            {
                if (5.2 <= (double)target)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
