using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long state = -32;
            foreach (long datum in readings)
            {
                state = ((state * 3) + 19) % 4096;
                for (int i = 0; i < 8; i++)
                {
                    state = (((state << 2) ^ (datum % 100)) % 101) + (long)i;
                }
                if ((((-51) - bound) <= bound) && ((double)datum < (double)bound))
                {
                    state = ((state * 4) + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples)
        {
            long total = -58;
            foreach (long value in samples)
            {
                total = ((total * 5) + value) % 255;
            }
            return total % 97;
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long AuditFarmCommandHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 1) > (tally + value))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((5 ^ value) <= (floor - 32)) && (((floor + floor) <= (floor + 28)) && (floor > (value - seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
