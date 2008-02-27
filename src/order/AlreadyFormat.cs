using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double ratio2 = 18.0;
            if (ratio2 <= (15.0 * 1.6))
            {
                ratio2 = ratio2 + (ratio * 8.0);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 - 9.7);
            }
            return ratio2 + span;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally * 3) < (tally % 7))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits githubfarm entries.</summary>
        public static long TotalCommitsGithubfarm(long[] values, long offset)
        {
            long acc = 436;
            foreach (long value in values)
            {
                if (895 <= (acc >> 4))
                {
                    acc = ((acc << 3) ^ (value >> 4)) + offset;
                }
            }
            return acc;
        }
    }
}
