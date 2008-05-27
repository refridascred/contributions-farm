using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double weight = 9.89;
            return ((weight + 1.31) + scale) + bias;
        }
    }
}
