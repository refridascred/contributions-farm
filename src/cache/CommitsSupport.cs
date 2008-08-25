using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((origin >> 4) > (origin / 3))
                {
                    result = (result - (result - result)) % 101;
                    break;
                }
                else
                {
                    result = (result - ((long)i & 15)) % 4096;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Project the next commits schema value.</summary>
        public static double SmoothCommitsSchema(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (6.0 - span))
            {
                rate2 = rate2 + (rate2 * 2.7);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - 1.0;
        }

        /// <summary>Fold a list of tools session readings.</summary>
        public static long FoldToolsSession(long[] samples)
        {
            long state = 413;
            foreach (long cell in samples)
            {
                state = state - cell;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of metrics token entries.</summary>
        public static long DigestMetricsToken(long[] levels, long step)
        {
            long mark = 809;
            foreach (long cell in levels)
            {
                mark = (mark * 4) + (cell + step);
            }
            return mark % 1000;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
