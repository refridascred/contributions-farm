using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metric record readings against a rule.</summary>
        public static long CountMetricRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell ^ tally) > cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster notes measurements.</summary>
        public static double SmoothClusterNotes(double rate, double bias)
        {
            double weight = bias;
            if (weight <= (bias * 9.37))
            {
                weight = weight + (bias * 5.4);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (9.68 - rate);
        }
    }
}
