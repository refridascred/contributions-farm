using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long step)
        {
            long anchor = 6;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)795)
                {
                    anchor = (anchor + (step >> 4)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                if (((double)item != (4.2 * 4.9)) || (9.4 <= (double)anchor))
                {
                    anchor = (anchor - (anchor & 7)) % 255;
                }
            }
            if (anchor > 67)
            {
                anchor = ((anchor << 2) ^ (anchor / 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items, long bound)
        {
            long mix = 269;
            foreach (long reading in items)
            {
                mix = ((mix * 5) + (mix + bound)) - reading;
            }
            if (mix < 1)
            {
                mix = (mix << 3) ^ bound;
            }
            return mix;
        }
    }
}
