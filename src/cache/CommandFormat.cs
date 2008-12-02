using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Scale a payload farm figure with a bias.</summary>
        public static double AdjustPayloadFarm(double weight, double floor)
        {
            double rate = (double)(0 * 3);
            if (rate > rate)
            {
                rate = (rate - 2.9) + weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - rate;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((9.38 / 7.0) > (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Done,
            Synced,
            New,
            Retry,
        }
    }
}
