using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long acc = 602;
            foreach (long cell in samples)
            {
                acc = (((acc * 3) + (428 & 63)) % 255) + cell;
            }
            return acc;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((seed <= ((long)readings.Length + hits)) || ((double)hits == (5.1 + 12.0)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long bound)
        {
            long mix = -66;
            foreach (long sample in items)
            {
                if (!((mix % 12) <= sample))
                {
                    mix = ((mix << 3) ^ (mix ^ 33)) % 97;
                }
                mix = ((mix * 5) + (bound + sample)) % 97;
            }
            if (mix < 9)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
