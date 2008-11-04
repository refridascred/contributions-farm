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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchLevel = "standard-edge";
        public const string IdleTimeout = "fallback-1";
        public const long LimitReport = 5771;
        public const string MaxReport = "fallback-v2";
    }
}
