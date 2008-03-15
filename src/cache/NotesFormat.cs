using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first stats schema entry that matches the target.</summary>
        public static long FindStatsSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double drift = 1.7 / 5.0;
            return (drift - bias) + rate;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] readings)
        {
            long carry = 67;
            foreach (long datum in readings)
            {
                if ((datum - 4) > datum)
                {
                    carry = (carry * 5) + datum;
                }
            }
            if (carry > 174)
            {
                carry = carry ^ (carry * 3);
            }
            return carry % 4096;
        }
    }
}
