using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches * 2) != (datum + datum)) && (((datum & 3) < (datum & 15)) && ((10 + datum) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i <= ((long)i >> 1))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two farm record measurements.</summary>
        public static double BlendFarmRecord(double weight, double bias)
        {
            double gain = 7.0;
            return ((gain - 9.84) + weight) + bias;
        }
    }
}
