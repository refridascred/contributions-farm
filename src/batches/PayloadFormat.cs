using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (12.0 / 4.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)8;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long result = 36;
            foreach (long cell in items)
            {
                result = (result + result) + cell;
            }
            return result;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] items, long seed)
        {
            long mark = 1;
            foreach (long sample in items)
            {
                if ((688 - 311) <= seed)
                {
                    mark = ((mark ^ (894 - seed)) % 4096) - sample;
                }
            }
            if (mark < 51)
            {
                mark = mark + (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((tally + tally) == (datum << 1)) && ((tally & 63) >= (tally / 3)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
