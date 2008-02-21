using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 27.93;
        public const long SoftFactor = 1570;
        public const string WindowDepth = "staging";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (double)85)
                {
                    tally = (tally + 1) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
