using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (7.3 > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long carry = 310;
            foreach (long cell in values)
            {
                if ((carry << 1) >= (carry & 63))
                {
                    carry = carry + (30 / 5);
                    carry = (carry ^ (cell * 3)) % 1000;
                }
                if ((cell << 2) > (carry + 20))
                {
                    carry = (carry * 2) + 72;
                }
            }
            return carry;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
