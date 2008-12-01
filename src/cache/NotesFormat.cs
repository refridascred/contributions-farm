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

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long CountFarmFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum <= (matches << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
