using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long CountStatsGithubfarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value <= (10.0 * 7.89)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((51 <= (reading - (-69))) || ((double)floor > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Pending,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 6525;
        public const string IdleFactor = "local";
        public const long HardRoute = 3502;
        public const long MinRoute = 9102;

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultSize = 77.97;
        public const double IdleProfile = 27.5;
        public const double BatchDepth = 67.5;
        public const long BatchProfile = 6670;
        public const long LimitProfile = 5315;
    }
}
