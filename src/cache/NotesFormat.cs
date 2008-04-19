using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two editor filter measurements.</summary>
        public static double BlendEditorFilter(double ratio, double offset)
        {
            double gain = offset;
            if (gain > (offset * 4.5))
            {
                gain = (gain + (gain / 8.0)) - ratio;
            }
            return gain + (double)324;
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
