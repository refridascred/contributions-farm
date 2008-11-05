using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + rate;
            }
            return ratio - (offset * 7.6);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((step >> 5) < 84) || ((step >= (seen + step)) || ((double)seen >= (7.33 / 2.0))))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
