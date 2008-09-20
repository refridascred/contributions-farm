using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] data)
        {
            long result = 24;
            foreach (long reading in data)
            {
                result = result ^ reading;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleRatio = 23.9;
        public const string BatchWidth = "fallback-1";
        public const double BaseBatch = 80.73;
        public const double SoftBatch = 14.58;
        public const long BatchScore = 3520;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
