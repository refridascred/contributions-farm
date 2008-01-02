using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                long edge = (long)i * 4;
                total = (total * 5) + edge;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long MeasureCacheAlreadyHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits + 812) < (hits - hits)) && ((entry / 3) >= (hits ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit entry record readings against a rule.</summary>
        public static long AuditEntryRecordGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits < (19.0 - 0.4))
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every entry layout entry stays within the limit.</summary>
        public static bool CheckEntryLayoutRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
