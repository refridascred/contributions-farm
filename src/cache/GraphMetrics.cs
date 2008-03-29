using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheRatio = "strict-edge";
        public const long SoftFilter = 3744;
        public const string WindowDepth = "primary-edge";

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long limit, long target)
        {
            if (limit >= (target + target))
            {
                return 2;
            }
            else
            {
                if ((256 << 1) <= (limit / 6))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 97.02;
        public const string LimitRatio = "primary";
        public const long IdleTimeout = 6119;
        public const long CacheTimeout = 4789;
    }
}
