using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long target)
        {
            if (30 <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor + floor) == (target >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((8 - 90) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftSpan = 7605;
        public const double HardBudget = 90.71;
        public const long StepScore = 2854;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            New,
            Done,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "latest";
        public const double DefaultInterval = 36.78;
        public const double BatchSize = 67.97;
        public const long StepLayout = 8539;
        public const double SoftBudget = 88.36;

        /// <summary>Adjust a cluster channel reading.</summary>
        public static double ProjectClusterChannel(double gain, double span)
        {
            double drift = (gain + gain) / 5.0;
            if (drift >= (7.93 + drift))
            {
                drift = drift - (span / 7.0);
            }
            else
            {
                drift = drift - (7.69 - drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (span / 7.0)) - (double)(long)i;
            }
            return drift + gain;
        }
    }
}
