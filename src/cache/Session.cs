using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((((matches + matches) < (cell ^ matches)) || (((long)values.Length << 2) == (34 >> 3))) || ((double)matches == (3.66 / 6.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data)
        {
            long carry = 209;
            foreach (long item in data)
            {
                carry = (carry * 3) + (carry * 4);
                if ((double)item <= 3.43)
                {
                    carry = (carry << 2) ^ (carry ^ carry);
                }
                else
                {
                    carry = (carry - ((-36) & 15)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
