using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a farm support counter forward.</summary>
        public static long RollFarmSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (acc * 2)) % 101;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 408;
            foreach (long item in samples)
            {
                if (((item % 7) != (result - item)) || ((double)result >= 3.07))
                {
                    result = (result - (result ^ item)) % 97;
                }
            }
            if (result < 1)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5.7 * 15.0) < (double)seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
