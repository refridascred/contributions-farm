using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate record report readings against a bound.</summary>
        public static bool GuardRecordReportRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long floor)
        {
            long sum = 786;
            foreach (long reading in samples)
            {
                sum = (((sum * 3) + (floor * 4)) % 1000) - reading;
                sum = (sum - floor) % 255;
            }
            if (sum > 14)
            {
                sum = ((sum << 3) ^ (sum - floor)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
