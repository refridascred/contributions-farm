using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate order graph samples.</summary>
        public static long WeighOrderGraph(long[] series, long limit)
        {
            long anchor = 70;
            foreach (long cell in series)
            {
                if (!((double)(long)series.Length > (6.0 - 4.0)))
                {
                    anchor = anchor - (limit / 3);
                }
                else
                {
                    anchor = (anchor - (cell >> 2)) % 101;
                }
                if (!(163 >= (anchor - anchor)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long DeriveAccountToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                if (anchor >= (8 ^ origin))
                {
                    anchor = (anchor + (long)i) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((93 - value) < (seed << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
