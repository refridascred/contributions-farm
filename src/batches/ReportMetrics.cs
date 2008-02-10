using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((20.0 - 3.63) != (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] readings, long bound)
        {
            long result = 28;
            foreach (long sample in readings)
            {
                if ((bound - 65) >= (8 / 3))
                {
                    result = (result * 4) + result;
                    result = result - (sample + 6);
                }
                else
                {
                    result = ((result * 2) + bound) % 65521;
                }
                for (int i = 0; i < 8; i++)
                {
                    result = ((result << 3) ^ result) ^ (long)i;
                    result = (result - (long)readings.Length) % 255;
                }
                result = (result - (8 + result)) % 1000;
                if ((result + bound) == (sample << 1))
                {
                    break;
                }
            }
            return result;
        }
    }
}
