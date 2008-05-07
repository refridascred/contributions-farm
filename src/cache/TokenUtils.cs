using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((target + 4) >= (cell * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double load = 1.34 - (double)5;
            if (load > (0.12 - bias))
            {
                load = load + (span * 6.17);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((tally + tally) <= (tally & 255)))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
