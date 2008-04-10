using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next layout notes value.</summary>
        public static double AdjustLayoutNotes(double gain, double offset)
        {
            double rate = gain;
            if (rate > 5.8)
            {
                rate = rate + (gain - offset);
            }
            return rate + (17.0 * 5.81);
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] readings, long offset)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                if ((long)readings.Length <= (anchor - offset))
                {
                    anchor = ((anchor * 2) + offset) % 1000;
                    anchor = ((anchor << 3) ^ (cell - offset)) % 1000;
                }
                if (((offset << 2) < (cell << 1)) || (offset >= (cell >> 4)))
                {
                    anchor = (anchor << 2) ^ offset;
                }
            }
            return anchor % 1000;
        }
    }
}
