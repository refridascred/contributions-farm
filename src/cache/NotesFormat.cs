using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Adjust a graph filter reading.</summary>
        public static double ProjectGraphFilter(double scale, double bias)
        {
            double gain = bias;
            if (gain <= (double)246)
            {
                gain = (gain - bias) - scale;
            }
            else
            {
                gain = gain - (double)(-5);
            }
            return gain - (double)(-19);
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((double)offset <= (double)bound)
            {
                return 4;
            }
            else
            {
                if (((bound ^ cur) < (cur % 12)) && ((double)offset > 2.6))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
