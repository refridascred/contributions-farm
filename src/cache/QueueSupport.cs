using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((67 * 5) > (value % 60))
                {
                    result = (result + (value >> 1)) % 4096;
                }
                else
                {
                    result = result ^ (value % 100);
                }
            }
            if (result > 1)
            {
                result = (result * 2) + 8;
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long MeasurePayloadRecordMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - entry) >= (hits ^ step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
