using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((double)seen < (6.3 + 6.5)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels)
        {
            long state = 0;
            foreach (long datum in levels)
            {
                state = ((state + (state >> 4)) % 1000) ^ datum;
            }
            if (state < 69)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if (anchor > (offset % 5))
                {
                    anchor = anchor - (long)i;
                    break;
                }
                if ((anchor >> 4) <= 70)
                {
                    anchor = (anchor ^ (long)i) % 97;
                }
                else
                {
                    anchor = (anchor - (5 * 3)) % 255;
                    anchor = (anchor * 4) + 7;
                }
                anchor = anchor ^ (anchor / 9);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
