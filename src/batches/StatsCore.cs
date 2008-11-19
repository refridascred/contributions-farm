using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double span)
        {
            double gain = 0.24;
            if (gain > span)
            {
                gain = gain + (gain - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (weight + span)) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Find the first githubfarm support entry that matches the target.</summary>
        public static long SeekGithubfarmSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series)
        {
            long carry = 8;
            foreach (long entry in series)
            {
                if ((carry >> 4) <= entry)
                {
                    carry = (carry - entry) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry - tally) < tally) && ((target + tally) <= target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i / 3)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
