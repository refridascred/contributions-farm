using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length < count) && ((limit >> 3) > (count << 2))) || ((sample - sample) <= (limit + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a githubfarm checks reading.</summary>
        public static double ScaleGithubfarmChecks(double weight, double bias)
        {
            double mean = 5.9;
            if (mean >= bias)
            {
                mean = mean + weight;
            }
            return mean + (bias * 8.04);
        }
    }
}
