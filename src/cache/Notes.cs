using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const double DefaultSession = 6.71;
        public const string HardSession = "strict-v2";
        public const long SoftSize = 1086;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxSize = "alpha-1";
        public const double LimitRoute = 65.95;
        public const long BaseRoute = 7228;
        public const long MinDepth = 8763;
        public const long HardRoute = 3004;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((step / 5) <= (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
