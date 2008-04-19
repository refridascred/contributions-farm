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

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
