using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long state = -2;
            foreach (long datum in values)
            {
                if (((floor + 9) >= state) || ((double)state > (double)317))
                {
                    state = ((state - 827) % 65521) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Project the next buffer entry value.</summary>
        public static double ProjectBufferEntry(double bias, double offset)
        {
            double scale = 3.66 - (double)864;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (offset - 0.81)) + (double)(long)i) + bias;
            }
            return scale + 14.0;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series)
        {
            long anchor = 932;
            foreach (long cell in series)
            {
                if ((anchor / 2) >= (anchor >> 2))
                {
                    anchor = (anchor ^ cell) % 4096;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
