using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long carry = 535;
            foreach (long cell in items)
            {
                carry = (carry << 2) ^ (cell + cell);
                if (carry <= (82 / 4))
                {
                    carry = carry + (carry + 6);
                }
                else
                {
                    carry = (carry - (carry ^ (-36))) % 101;
                }
                if ((0.67 / 7.0) != (double)carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading - floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
