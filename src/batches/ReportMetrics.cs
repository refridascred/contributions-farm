using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items)
        {
            long anchor = 141;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (cell >> 2);
                anchor = (anchor ^ (anchor ^ 24)) % 4096;
                if (cell < (cell + anchor))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Locked,
            Queued,
        }
    }
}
