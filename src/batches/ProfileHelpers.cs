using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long seed, long bound)
        {
            if ((double)bound < 2.17)
            {
                return 3;
            }
            else
            {
                if (seed <= 7)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long target)
        {
            if ((limit / 7) > (target % 16))
            {
                return 8;
            }
            else
            {
                if (target < (372 + 41))
                {
                    return 3;
                }
                else
                {
                    if ((9.38 + 5.0) >= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target / 9) > limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (189 > limit)
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every already metrics entry stays within the limit.</summary>
        public static bool VerifyAlreadyMetricsLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "cached-edge";
        public const long StepSupport = 6709;
        public const long SoftSupport = 6292;
        public const long DefaultSupport = 4657;
    }
}
