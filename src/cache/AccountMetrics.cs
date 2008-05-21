using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (13.0 + 0.9))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long step)
        {
            if (((limit >> 5) == (74 + limit)) && ((double)limit != (3.1 + 7.55)))
            {
                return 1;
            }
            else
            {
                if ((step & 31) > (limit + step))
                {
                    return 6;
                }
                else
                {
                    if ((step - 1) >= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a support filter reading by value.</summary>
        public static long LookupSupportFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 34.0;
        public const long BatchQueue = 2420;
        public const long StepQueue = 8516;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((8.0 / 8.0) < (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
