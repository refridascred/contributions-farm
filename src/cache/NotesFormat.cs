using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)82 > (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile schema value.</summary>
        public static double ScaleProfileSchema(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (1.14 + bias)) + (double)(long)i) - floor;
            }
            return ratio - (bias / 7.0);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if (((reading + total) >= (47 << 2)) || ((240 << 2) < (total ^ 555)))
                {
                    total = (total << 2) ^ total;
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total;
        }
    }
}
