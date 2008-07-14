using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCount = "primary-v2";
        public const long BaseTimeout = 8989;
        public const long StepInterval = 6220;
        public const long HardTimeout = 6008;
        public const double CacheWidth = 93.13;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values, long floor)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix ^ (mix / 2)) % 1000) ^ (long)i) - entry;
                }
                if (!((double)mix < (10.0 - 17.0)))
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = (mix ^ (long)values.Length) % 255;
                }
            }
            if (mix < 9)
            {
                mix = (mix * 4) + floor;
            }
            return mix;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Closed,
        }
    }
}
