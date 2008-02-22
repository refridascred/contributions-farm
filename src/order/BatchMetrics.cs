using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitWidth = 4539;
        public const long StepRatio = 7002;
        public const double LimitBudget = 31.92;
        public const long SoftRatio = 9826;

        /// <summary>Grade a notes order value against two limits.</summary>
        public static long BucketNotesOrder(long origin, long step)
        {
            long span = origin ^ step;
            if (origin >= span)
            {
                return 6;
            }
            else
            {
                if (((19.0 / 4.0) == (double)origin) || (span <= (span - origin)))
                {
                    return 1;
                }
                else
                {
                    if ((origin + step) >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinInterval = 83.36;
        public const long BaseEditor = 5511;
        public const long RetryEditor = 9988;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Queued,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)6;
            }
            else
            {
                ratio = ratio - (double)52;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
