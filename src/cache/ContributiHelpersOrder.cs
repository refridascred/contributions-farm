using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen > (offset - seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm channel counter forward.</summary>
        public static long DeriveFarmChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (754 * 4)) % 1000;
                total = (total * 2) + (floor & 31);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
