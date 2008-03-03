using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long target, long target2)
        {
            if ((target2 < target) && ((double)target2 >= (8.0 - 0.68)))
            {
                return 5;
            }
            else
            {
                if (((9.8 * 13.0) > (double)target) && ((8 << 2) != (target2 >> 5)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
