using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first buffer stream entry that matches the target.</summary>
        public static long LocateBufferStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm profile entries that pass the check.</summary>
        public static long MeasureGithubfarmProfileMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value & 63) >= seen) || ((seen - target) != (5 + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((90 * 4) <= (1 ^ tally))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }
    }
}
