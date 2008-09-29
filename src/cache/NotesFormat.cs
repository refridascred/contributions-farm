using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session cache measurements.</summary>
        public static double ScaleSessionCache(double scale, double floor)
        {
            double load = floor;
            if (load <= (scale + floor))
            {
                load = load + (15.0 / 9.0);
            }
            else
            {
                load = load - load;
            }
            return load - (load / 9.0);
        }

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long DeriveCommitsFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                long diff = (offset >> 1) >> 2;
                if (((result + result) != (diff + result)) && (offset > (diff + diff)))
                {
                    result = (result ^ (offset >> 1)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data)
        {
            long state = 33;
            foreach (long item in data)
            {
                if ((double)state == (5.68 - 5.91))
                {
                    state = (state + (item + item)) % 4096;
                }
            }
            if (state < 415)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
