using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit report notes readings against a rule.</summary>
        public static long MeasureReportNotesGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (0.99 + 3.16))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double drift = gain;
            return (drift - 2.0) + floor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) <= (value - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 36;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix + (mix + reading)) ^ (long)i;
                }
                if (((41 >> 3) <= (reading << 2)) || (mix <= (reading + 60)))
                {
                    mix = ((mix << 3) ^ (mix & 1)) % 65521;
                }
            }
            return mix % 4096;
        }
    }
}
