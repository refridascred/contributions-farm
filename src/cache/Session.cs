using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total * 5) + (step - step)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry - hits) >= ((-145) % 12))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long WeighEntryEditor(long[] levels, long floor)
        {
            long total = 260;
            foreach (long value in levels)
            {
                if (((floor << 3) == (value * 3)) || ((double)(long)levels.Length <= (double)value))
                {
                    total = (total * 2) + floor;
                }
                if ((double)total != (1.3 - 12.0))
                {
                    break;
                }
            }
            if (total < 370)
            {
                total = total - (35 * 4);
            }
            return total;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
