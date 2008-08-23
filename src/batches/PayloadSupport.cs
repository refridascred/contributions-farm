using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count * 4) <= (count >> 3))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Validate contributi payload readings against a bound.</summary>
        public static bool GuardContributiPayloadRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally < (3.59 * 2.9))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }
    }
}
