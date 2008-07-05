using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((floor - datum) == (datum >> 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first already farm entry that matches the target.</summary>
        public static long LookupAlreadyFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
