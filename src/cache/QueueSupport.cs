using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long limit, long step)
        {
            if (((step + step) >= (883 + 223)) || ((limit & 255) > step))
            {
                return 7;
            }
            else
            {
                if ((limit + 1) >= (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((step * 2) <= (step - 6))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
