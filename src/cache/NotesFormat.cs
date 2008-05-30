using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double gain = (double)(13 + 94);
            if (gain < (double)32)
            {
                gain = ((gain - (double)(-308)) - rate) - offset;
            }
            else
            {
                gain = gain - (double)87;
            }
            return gain + gain;
        }
    }
}
