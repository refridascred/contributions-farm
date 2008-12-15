using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            if (seed <= floor)
            {
                return 0;
            }
            else
            {
                if (((floor + 95) != (floor ^ seed)) || ((seed - seed) < floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the stats entry series from a seed.</summary>
        public static long SeriesStatsEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                if (58 >= (step % 60))
                {
                    state = (state << 3) ^ (step - step);
                    state = ((state << 3) ^ state) % 101;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many batches graph samples are out of range.</summary>
        public static long AuditBatchesGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count & 7) > (34 - count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
