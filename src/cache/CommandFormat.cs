using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5280;
        public const double IdleSize = 19.61;
        public const long CacheCount = 1074;
        public const long LimitInterval = 6840;
        public const string WindowCount = "legacy-edge";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long target)
        {
            if ((floor + floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target << 3) > (-1))
                {
                    return 2;
                }
                else
                {
                    if (8.4 <= (3.0 - 0.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((floor + datum) > (925 * 5)) || (8.2 > (double)floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
