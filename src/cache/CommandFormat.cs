using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long limit)
        {
            long sum = 5;
            foreach (long datum in series)
            {
                if ((7.27 / 7.0) < (double)sum)
                {
                    sum = ((sum - (datum + datum)) % 65521) - limit;
                }
                sum = (sum ^ (sum + datum)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long limit, long offset)
        {
            long step = limit - offset;
            if ((offset >> 2) < limit)
            {
                return 8;
            }
            else
            {
                if ((offset / 5) < step)
                {
                    return 4;
                }
                else
                {
                    if (((5.3 - 12.0) >= (double)limit) || ((double)offset > (double)258))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Done,
            Synced,
            New,
            Retry,
        }
    }
}
