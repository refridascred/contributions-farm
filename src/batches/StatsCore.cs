using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double scale = span - (11.0 + span);
            if (scale > (double)590)
            {
                scale = scale + (scale / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - (ratio + ratio);
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

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
