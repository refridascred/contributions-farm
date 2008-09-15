using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstWidth = 2973;
        public const long SoftRatio = 4055;
        public const double StepCommand = 25.77;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Synced,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] levels)
        {
            long acc = 33;
            foreach (long reading in levels)
            {
                if ((6 + 532) > (reading + acc))
                {
                    acc = ((acc * 3) + (long)levels.Length) % 97;
                }
            }
            if (acc > 25)
            {
                acc = (acc ^ (acc - 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((28 - cell) > seen)
                {
                    seen = seen + 3;
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
