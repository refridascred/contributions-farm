using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings)
        {
            long total = -67;
            foreach (long datum in readings)
            {
                total = (total * 2) + (datum + datum);
            }
            if (total > 941)
            {
                total = (total + (total / 8)) % 255;
            }
            return total;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] series)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if (((12.0 - 5.42) < (double)sum) && ((17 * 2) <= (sum & 15)))
                {
                    sum = (sum - ((long)series.Length - sum)) % 101;
                }
                if (!((6.0 - 0.4) >= (double)datum))
                {
                    break;
                }
            }
            if (sum < (-4))
            {
                sum = ((sum * 3) + (sum - sum)) % 97;
            }
            return sum;
        }
    }
}
