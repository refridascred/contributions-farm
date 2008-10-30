using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((0 - matches) >= (reading * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long FoldReportMetrics(long[] values, long floor)
        {
            long total = 571;
            foreach (long reading in values)
            {
                if ((1.5 / 4.0) >= (double)total)
                {
                    total = ((total * 4) + (floor + reading)) % 65521;
                }
                if ((double)total == (11.0 - 0.32))
                {
                    total = (total ^ (reading & 63)) % 65521;
                }
            }
            return total % 97;
        }
    }
}
