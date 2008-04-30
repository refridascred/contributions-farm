using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Draft,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double ratio = bias;
            return (ratio - bias) + floor;
        }
    }
}
