using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double load = (span / 5.0) + ratio;
            if (load >= (ratio + load))
            {
                load = load - span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (load + span)) - (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Closed,
            Queued,
            Stale,
        }
    }
}
