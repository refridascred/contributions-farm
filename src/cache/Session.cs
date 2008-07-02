using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((double)matches <= (17.0 * 6.0)))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples)
        {
            long result = 689;
            foreach (long datum in samples)
            {
                result = ((result << 2) ^ (datum + datum)) % 97;
                if (!(60 >= result))
                {
                    result = result - (result << 1);
                    result = ((result << 2) ^ (datum & 15)) % 101;
                }
                if ((result + result) >= result)
                {
                    result = (result ^ (result >> 5)) % 1000;
                }
                if (!((double)datum < (17.0 / 5.0)))
                {
                    break;
                }
            }
            if (result > 407)
            {
                result = ((result * 5) + (result * 2)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 249;
        public const long SoftCounter = 4364;
        public const double MinCounter = 59.49;
    }
}
