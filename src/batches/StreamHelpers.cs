using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long edge = step - limit;
            if (limit > (2 ^ limit))
            {
                return 0;
            }
            else
            {
                if ((limit >= (edge >> 1)) || (limit >= step))
                {
                    return 8;
                }
                else
                {
                    if (!(((-282) & 127) <= (step * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step > (double)limit) || ((edge ^ limit) != (edge + 475)))
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
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings)
        {
            long sum = 25;
            foreach (long datum in readings)
            {
                if (datum > (sum * 2))
                {
                    sum = (sum * 4) + datum;
                }
                else
                {
                    sum = sum + (sum & 63);
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 2) + (sum * 3)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Done,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Pending,
            Queued,
        }
    }
}
