using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of stats batches readings.</summary>
        public static long TotalStatsBatches(long[] data)
        {
            long acc = 683;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc * 5) + acc) % 255) + (long)i;
                }
                if ((reading * 4) >= acc)
                {
                    acc = acc - reading;
                    acc = (acc + (acc * 3)) % 1000;
                    continue;
                }
                else
                {
                    acc = (acc ^ 7) % 255;
                }
                acc = (acc ^ (reading + 686)) % 255;
            }
            if (acc < 725)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen >= (item + seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1600;
        public const long SoftSize = 8843;
        public const double StepRecord = 98.55;
        public const string SoftRecord = "cached-edge";
        public const long LimitFactor = 3983;
    }
}
