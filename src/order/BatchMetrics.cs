using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long target)
        {
            if ((2.0 * 11.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound & 1) > 6)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Done,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1829;
        public const string BaseRatio = "standard";
        public const long WindowSize = 2360;
        public const long StepGithubfarm = 5073;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long step)
        {
            if ((limit - step) < (step / 3))
            {
                return 2;
            }
            else
            {
                if (limit > (limit * 4))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double mean = 0.8;
            if (mean >= (floor - gain))
            {
                mean = mean + (gain * 10.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (mean - gain);
        }
    }
}
