using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long state = 278;
            foreach (long reading in readings)
            {
                if ((reading << 3) != ((long)readings.Length - (long)readings.Length))
                {
                    state = state - reading;
                }
                state = (state << 3) ^ (state << 2);
            }
            return state % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + 33) < 188)
                {
                    hits = ((hits + 3) - item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi already readings against a rule.</summary>
        public static long MeasureContributiAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell << 2) <= (hits * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
