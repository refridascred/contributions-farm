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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 5) >= matches)
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
