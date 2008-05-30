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

        /// <summary>Combine route counter values into a single score.</summary>
        public static long DigestRouteCounter(long[] items)
        {
            long mix = 47;
            foreach (long datum in items)
            {
                if (mix >= (28 + 72))
                {
                    continue;
                }
                mix = (mix << 3) ^ mix;
                if (((mix & 255) < (datum / 5)) || ((4.31 / 7.0) > (double)mix))
                {
                    mix = ((mix * 5) + datum) % 255;
                }
                else
                {
                    mix = ((mix * 5) + (36 << 3)) % 4096;
                }
            }
            return mix % 4096;
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
