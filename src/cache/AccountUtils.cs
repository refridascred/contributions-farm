using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two context notes measurements.</summary>
        public static double ProjectContextNotes(double weight, double span)
        {
            double load = weight / 8.0;
            if (load >= span)
            {
                load = load + (double)461;
            }
            else
            {
                load = load + (weight + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (0.19 - load)) - (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Roll a entry stats counter forward.</summary>
        public static long RollEntryStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((result + result) < (long)i)
                {
                    result = (result + (long)i) % 4096;
                }
                result = (result * 4) + seed;
                result = result - ((long)i + result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the checks channel entries that pass the check.</summary>
        public static long AuditChecksChannelGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)count <= 6.3))
                {
                    count = ((count + 2) - value) + offset;
                }
            }
            return count;
        }
    }
}
