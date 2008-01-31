using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
