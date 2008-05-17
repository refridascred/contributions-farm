using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Synced,
            New,
            Done,
        }

        /// <summary>Adjust a stream format reading.</summary>
        public static double BlendStreamFormat(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > (double)55)
            {
                ratio = ratio + (floor - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 1.4) - (double)(long)i;
            }
            return ratio - (bias * 1.7);
        }
    }
}
