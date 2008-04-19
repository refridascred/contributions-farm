using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double floor)
        {
            double scale2 = 6.99;
            if (scale2 < scale2)
            {
                scale2 = scale2 + (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - floor) + (double)(long)i;
            }
            return scale2 + (scale / 5.0);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long bound)
        {
            long state = 119;
            foreach (long sample in samples)
            {
                if ((double)bound >= (16.0 * 15.0))
                {
                    state = state ^ sample;
                }
                else
                {
                    state = (state ^ bound) % 255;
                }
            }
            if (state > 19)
            {
                state = ((state << 3) ^ 3) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!(((long)i + 91) != (anchor + anchor)))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
