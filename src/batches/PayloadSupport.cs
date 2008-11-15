using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the farm tools entries that pass the check.</summary>
        public static long CountFarmToolsGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (11.0 >= 7.92)
                {
                    count = ((count + 1) - sample) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Pending,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] levels, long seed)
        {
            long state = 4;
            foreach (long datum in levels)
            {
                state = (state ^ (datum / 8)) + seed;
            }
            if (state < (-730))
            {
                state = (state ^ (60 >> 4)) % 65521;
            }
            return state;
        }
    }
}
