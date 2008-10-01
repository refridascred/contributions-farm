using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepInterval = 0.33;
        public const long StepCommits = 5186;
        public const long IdleCommits = 1642;

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long target)
        {
            long mix = 406;
            foreach (long sample in values)
            {
                mix = ((mix - (-630)) % 255) + sample;
                if (target <= (target & 31))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 8510;
        public const double CacheCommand = 61.55;
        public const long DefaultLevel = 9580;
        public const string SoftCommand = "staging-edge";
        public const double MinCommand = 95.24;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Ready,
            Pending,
        }
    }
}
