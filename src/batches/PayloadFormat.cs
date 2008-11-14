using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < 9.4)
                {
                    hits = ((hits + 1) + sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 2) ^ (mark + bound);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings, long seed)
        {
            long mark = 48;
            foreach (long entry in readings)
            {
                if ((mark > (mark << 1)) || ((seed * 4) < entry))
                {
                    mark = ((mark * 3) + (entry + entry)) % 1000;
                }
                else
                {
                    mark = (mark + (seed / 3)) % 101;
                }
            }
            return mark;
        }
    }
}
