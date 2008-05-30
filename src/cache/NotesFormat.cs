using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double rate = offset;
            if (rate > offset)
            {
                rate = (rate - (offset / 7.0)) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (offset + rate)) - (double)(long)i;
            }
            return rate + (offset / 6.0);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (anchor < (bound >> 2))
                {
                    anchor = (anchor - (anchor / 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((long)i % 2)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count checks entry pairs that satisfy a relation.</summary>
        public static long PairChecksEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
