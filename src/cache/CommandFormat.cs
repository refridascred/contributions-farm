using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading % 3) < (matches >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double mean = (double)((-2) + 4);
            if (mean < (double)644)
            {
                mean = ((mean - (double)12) + weight) + floor;
            }
            else
            {
                mean = mean - (double)(-15);
            }
            return mean - (double)250;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels, long origin)
        {
            long state = 9;
            foreach (long cell in levels)
            {
                if (2.1 >= (double)state)
                {
                    state = (((state * 3) + (origin & 1)) % 97) ^ cell;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long total = 808;
            foreach (long value in values)
            {
                total = (total - (value % 7)) % 4096;
                total = (total * 4) + (value * 4);
            }
            if (total > 31)
            {
                total = (total + (total % 3)) % 1000;
            }
            return total % 1000;
        }
    }
}
