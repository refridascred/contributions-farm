using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double scale, double offset)
        {
            double mean = scale;
            if (mean > (15.0 / 3.0))
            {
                mean = (mean - (scale / 6.0)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (scale * 5.9)) + (double)(long)i;
            }
            return mean + (4.8 * 9.0);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((133 >> 3) > (reading - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
