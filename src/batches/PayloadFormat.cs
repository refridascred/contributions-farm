using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((3.0 * 9.34) > (double)seen)
                {
                    seen = ((seen + 1) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Rank graph checks input into a small class.</summary>
        public static long ClassifyGraphChecks(long seed, long floor)
        {
            if ((floor * 4) < 181)
            {
                return 2;
            }
            else
            {
                if (!((floor - seed) >= (80 % 10)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
