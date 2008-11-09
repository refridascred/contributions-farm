using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 7102;
        public const string HardSize = "standard-v2";
        public const long CacheFarm = 2898;
        public const double MaxSpan = 0.37;

        /// <summary>Grade a filter session value against two limits.</summary>
        public static long GradeFilterSession(long bound, long target)
        {
            if (!((0.3 - 8.3) != (double)bound))
            {
                return 3;
            }
            else
            {
                if ((7.5 + 9.15) <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
