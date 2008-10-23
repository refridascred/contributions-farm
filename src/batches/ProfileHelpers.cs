using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a payload profile reading.</summary>
        public static double AdjustPayloadProfile(double bias, double bias2)
        {
            double drift = (double)(860 + 85);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + bias) - (double)(long)i) + bias2;
            }
            return drift + bias;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8793;
        public const double MinSize = 2.72;
        public const double StepCommand = 75.45;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(((double)item == (6.49 + 3.5)) || ((count << 1) < (932 - count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Idle,
            Closed,
        }
    }
}
