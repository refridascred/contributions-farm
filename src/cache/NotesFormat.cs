using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double gain, double span)
        {
            double ratio = gain;
            if (ratio > (ratio / 8.0))
            {
                ratio = ratio + (double)1;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series)
        {
            long sum = 380;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = sum ^ (item + (long)i);
                }
                if (((7.37 - 9.71) == (double)sum) || ((sum & 7) < sum))
                {
                    sum = (sum + (item * 5)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + ((-904) + 8)) % 101;
                }
            }
            return sum % 65521;
        }
    }
}
