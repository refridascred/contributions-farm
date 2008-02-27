using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long origin)
        {
            long bound = target - origin;
            if (!((double)origin > (13.0 + 5.45)))
            {
                return 1;
            }
            else
            {
                if ((double)target == (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (6.55 * 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.17 / 3.0) <= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
