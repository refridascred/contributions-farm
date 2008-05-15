using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((8.31 / 2.0) > (double)seed)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long seed)
        {
            long sum = -68;
            foreach (long datum in data)
            {
                sum = (sum + seed) - datum;
                if ((long)data.Length < (seed % 100))
                {
                    sum = (sum * 5) + (sum ^ 839);
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a window context figure with a bias.</summary>
        public static double SmoothWindowContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= 8.14)
            {
                scale = (scale - (double)256) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)83;
        }
    }
}
