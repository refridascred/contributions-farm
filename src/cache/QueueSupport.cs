using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Pending,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Locate a metric notes reading by value.</summary>
        public static long LocateMetricNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry counter figure with a bias.</summary>
        public static double AdjustEntryCounter(double gain, double span)
        {
            double load = (16.0 * 4.3) * 8.19;
            if (load > (gain + gain))
            {
                load = load - (double)66;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 4.0) - (double)(long)i;
            }
            return load - span;
        }
    }
}
