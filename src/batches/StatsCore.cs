using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long target)
        {
            long state = -326;
            foreach (long cell in series)
            {
                if (cell >= (target * 3))
                {
                    state = (state + state) % 97;
                }
            }
            return state;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits * 2) > 6)
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ (total ^ 60)) % 1000;
                if ((total ^ bound) <= (total / 6))
                {
                    total = total - total;
                    total = ((total * 3) + bound) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheFactor = 43.5;
        public const long WindowSpan = 6765;
        public const long SoftTimeout = 3885;
        public const long MaxWindow = 5324;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Size { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
