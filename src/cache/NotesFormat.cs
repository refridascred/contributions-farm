using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate channel session readings against a bound.</summary>
        public static bool GuardChannelSessionRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double ratio2 = (ratio - 17.0) - (bias + 6.23);
            return ratio2 - (ratio2 - ratio);
        }

        /// <summary>Combine filter entry values into a single score.</summary>
        public static long FoldFilterEntry(long[] readings, long seed)
        {
            long anchor = 979;
            foreach (long reading in readings)
            {
                if (((reading >> 4) >= (seed - seed)) && ((seed - reading) != (reading / 2)))
                {
                    anchor = ((anchor << 3) ^ (seed << 2)) % 255;
                }
            }
            if (anchor > (-9))
            {
                anchor = anchor + (seed * 4);
            }
            return anchor % 97;
        }
    }
}
