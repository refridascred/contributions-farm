using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinFactor = 24.55;
        public const long CacheInterval = 1544;
        public const long MinInterval = 9037;
        public const long SoftRatio = 3560;
        public const long IdleChannel = 7976;

        /// <summary>Look up the position of a context githubfarm sample.</summary>
        public static long LocateContextGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((554 % 60) > (origin + origin))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits - cell) <= 67) || (hits > (hits >> 2)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            long span = origin + target;
            if ((96 >= (span / 8)) || ((target >> 3) == (origin - span)))
            {
                return 4;
            }
            else
            {
                if (span >= (origin & 7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
