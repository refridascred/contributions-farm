using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((6.7 / 8.0) < (double)reading)
                {
                    anchor = anchor + (anchor / 8);
                }
            }
            if (anchor < 49)
            {
                anchor = anchor + (97 / 3);
            }
            return anchor;
        }
    }
}
