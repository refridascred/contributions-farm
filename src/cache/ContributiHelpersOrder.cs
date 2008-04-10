using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next graph contributi value from a seed.</summary>
        public static long SeriesGraphContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((95 + step) >= sum))
                {
                    sum = sum + (step ^ sum);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
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
