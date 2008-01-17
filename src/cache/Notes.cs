using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 4) <= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double bias)
        {
            double weight2 = (weight / 9.0) / 5.0;
            if (weight2 < (weight / 4.0))
            {
                weight2 = (weight2 + 12.0) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 + 2.53;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
