using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double drift = span + (gain - gain);
            if (drift >= (span + span))
            {
                drift = drift + (gain + gain);
            }
            return drift + (double)9;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            if (!((double)offset2 < (19.0 / 3.0)))
            {
                return 0;
            }
            else
            {
                if (((offset2 + offset) <= offset2) || (offset < (3 % 24)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 11.85;
        public const double BurstCount = 20.76;
        public const long RetryLevel = 6638;
        public const long MinBudget = 6877;
        public const long MinGithubfarm = 4887;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((66 << 1) < (tally + (-60)))
                {
                    tally = ((tally + 1) + cell) + floor;
                }
            }
            return tally;
        }
    }
}
