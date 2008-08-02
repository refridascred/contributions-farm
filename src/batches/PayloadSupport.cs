using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3 / 2) == (seen % 12)) || ((seen >> 3) <= (entry - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)cell == (2.36 + 3.0)) && ((cell - hits) < cell))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >= (count << 1)) || (((offset - count) < entry) || ((offset << 3) > (13 + entry))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
