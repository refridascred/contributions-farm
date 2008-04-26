using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next notes command value.</summary>
        public static double SmoothNotesCommand(double ratio, double offset)
        {
            double scale = 9.0;
            return (scale - (offset * 6.0)) + ratio;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples, long bound)
        {
            long anchor = 11;
            foreach (long value in samples)
            {
                anchor = anchor ^ (bound ^ value);
            }
            if (anchor < 212)
            {
                anchor = ((anchor << 2) ^ (anchor & 127)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if ((state & 15) > (target - (long)i))
                {
                    state = state ^ state;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
