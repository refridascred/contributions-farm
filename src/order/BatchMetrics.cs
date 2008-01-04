using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > (bias * 5.4))
            {
                bias2 = bias2 - (bias2 / 9.0);
            }
            else
            {
                bias2 = bias2 - 6.9;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 - (scale * 16.0);
        }

        /// <summary>Measure how many commits support samples are out of range.</summary>
        public static long MeasureCommitsSupportOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (8 < (offset << 3))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            if ((double)offset <= (2.1 * 16.0))
            {
                return 1;
            }
            else
            {
                if ((offset & 255) >= floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor + offset) == (floor / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Active,
            Done,
        }
    }
}
