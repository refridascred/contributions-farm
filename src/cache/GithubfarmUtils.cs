using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)datum != (4.6 - 8.13)) || ((double)origin > (8.0 / 3.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double bias2 = 5.25;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + scale) - (double)(long)i) - bias;
            }
            return bias2 - scale;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((-20) >> 2) == (sample % 3))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
