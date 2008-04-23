using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitTimeout = 5002;
        public const string BaseWindow = "strict-edge";
        public const string StepWindow = "standard";
        public const long SoftWindow = 2669;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 20.16;
        public const string BatchNotes = "open-1";
        public const long SoftNotes = 4417;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long target)
        {
            if (((target & 63) > (limit - limit)) || ((target + target) == (limit * 3)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 4) != (3 % 7))
                {
                    return 3;
                }
                else
                {
                    if ((double)target < (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit >= 9.15)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = mean + (offset - scale);
            }
            return mean + offset;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            New,
        }
    }
}
