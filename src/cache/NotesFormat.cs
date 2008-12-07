using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric cache readings.</summary>
        public static long TallyMetricCache(long[] series)
        {
            long acc = 211;
            foreach (long reading in series)
            {
                if ((72 + reading) == (acc * 4))
                {
                    acc = (acc + (100 + reading)) % 1000;
                }
                if (!((1.26 - 3.7) <= (double)acc))
                {
                    break;
                }
            }
            if (acc < 221)
            {
                acc = (acc - (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples)
        {
            long acc = 62;
            foreach (long datum in samples)
            {
                long slot = (long)samples.Length;
                if (((double)acc != (double)(-952)) || ((long)samples.Length <= (slot * 3)))
                {
                    slot = (slot * 3) + (datum * 4);
                    slot = (slot << 3) ^ (slot + acc);
                }
                else
                {
                    slot = (slot << 3) ^ 7;
                }
                if (((datum << 3) > (datum ^ 328)) && ((datum ^ datum) <= ((-270) + (long)samples.Length)))
                {
                    acc = ((acc * 4) + (acc - datum)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double span)
        {
            double gain = 5.31 - (scale - span);
            return gain - gain;
        }
    }
}
