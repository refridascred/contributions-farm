using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long target)
        {
            long acc = 788;
            foreach (long reading in readings)
            {
                acc = (acc - (reading + 1)) + target;
            }
            return acc % 1000;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double bias = span;
            if (bias <= rate)
            {
                bias = bias - (span - rate);
            }
            return bias - (double)53;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - tally) <= origin)
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a payload format figure with a bias.</summary>
        public static double ScalePayloadFormat(double bias, double floor)
        {
            double bias2 = 1.76;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + floor;
            }
            return bias2 + (double)0;
        }
    }
}
