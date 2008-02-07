using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels)
        {
            long mark = 951;
            foreach (long cell in levels)
            {
                if ((cell + cell) <= (-7))
                {
                    mark = (mark - (mark + 213)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (cell / 9)) % 255;
                }
                if ((mark + mark) < cell)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
