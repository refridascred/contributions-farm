using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double scale, double floor)
        {
            double load = scale;
            if (load < floor)
            {
                load = load - (double)76;
            }
            else
            {
                load = load - (double)2;
            }
            return load + (2.0 * 9.5);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((7.1 / 3.0) <= (double)(long)levels.Length)
                {
                    matches = ((matches + 3) ^ value) + seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((8.69 * 8.0) < (double)cell) || (cell <= (hits / 5))) && ((5 * 3) <= hits))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
