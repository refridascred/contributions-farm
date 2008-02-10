using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)4)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            return bias2 - (0.3 + weight);
        }

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long MeasureFormatGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - seen) > seen)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
