using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            if (((floor + floor) == (832 * 3)) || (floor <= (floor << 1)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 > (6.0 - 10.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a already cluster counter forward.</summary>
        public static long RollAlreadyCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the order report entries that pass the check.</summary>
        public static long MeasureOrderReportMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((0.75 - 5.85) == (double)entry)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
