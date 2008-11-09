using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many support stats samples are out of range.</summary>
        public static long AuditSupportStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen ^ 36) >= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double bias = offset / 7.0;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)7) + (double)(long)i) + weight;
            }
            return bias + offset;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "open-v2";
        public const double MinSize = 88.83;
        public const long SoftSpan = 8966;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            long next = bound + floor;
            if ((bound - 3) < (next + bound))
            {
                return 3;
            }
            else
            {
                if ((floor <= (619 + floor)) || ((54 / 5) != (next - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > (1.8 - 14.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)next >= (8.9 * 16.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
