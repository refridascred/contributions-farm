using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Paused,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double bias2 = (double)(96 / 4);
            if (bias2 > (double)12)
            {
                bias2 = bias2 + (bias / 2.0);
            }
            return bias2 + (bias2 + weight);
        }

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long LocateContributiRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
