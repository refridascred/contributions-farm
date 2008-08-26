using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values)
        {
            long total = 87;
            foreach (long value in values)
            {
                total = (total + (value << 3)) % 101;
                if (value < (total >> 4))
                {
                    total = (total + (total - value)) % 255;
                }
            }
            if (total < 8)
            {
                total = (total * 5) + (112 >> 3);
            }
            return total % 1000;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Pending,
            Stale,
            Closed,
            Failed,
        }
    }
}
