using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ (-130)) != (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (seed & 7);
                sum = sum ^ (seed * 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
