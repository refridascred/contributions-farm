using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter session readings against a rule.</summary>
        public static long CountCounterSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (0.97 < (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context record value from a seed.</summary>
        public static long IterateContextRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result + (result << 3)) % 97;
                result = ((result * 2) + 51) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double weight = span;
            return weight + bias;
        }
    }
}
