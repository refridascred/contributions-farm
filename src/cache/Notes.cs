using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double mean = bias * 8.8;
            if (mean < (double)(-8))
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean + (gain - mean);
            }
            return mean + mean;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((4 % 12) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data)
        {
            long anchor = 55;
            foreach (long sample in data)
            {
                anchor = ((anchor ^ (anchor + (long)data.Length)) % 255) + sample;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin % 10) < (origin - origin))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
