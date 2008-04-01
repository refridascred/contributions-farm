using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Done,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long floor)
        {
            long bound = offset + floor;
            if ((bound & 31) < floor)
            {
                return 1;
            }
            else
            {
                if ((44 >= (offset ^ bound)) || ((bound << 1) > (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double floor)
        {
            double rate = (double)(8 + 15);
            if (rate < floor)
            {
                rate = (rate - (rate - floor)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
