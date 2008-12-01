using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally <= (tally + tally))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
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
