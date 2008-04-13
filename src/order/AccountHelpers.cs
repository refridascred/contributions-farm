using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 6089;
        public const double CacheInterval = 3.27;
        public const long CacheNotes = 1014;
        public const double RetryNotes = 85.72;
        public const long WindowNotes = 2274;

        /// <summary>Classify a command layout pair into a bucket.</summary>
        public static long ClassifyCommandLayout(long seed, long floor)
        {
            if ((46 + (-7)) != (floor * 3))
            {
                return 2;
            }
            else
            {
                if ((double)seed < 1.47)
                {
                    return 7;
                }
                else
                {
                    if (floor <= (567 + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((45 / 6) != (cell - cell)) && ((8.6 * 0.28) == (double)cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate session metric readings against a bound.</summary>
        public static bool CheckSessionMetricLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
