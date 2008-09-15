using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchTimeout = 6424;
        public const long SoftCache = 6921;
        public const long HardCache = 6857;
        public const long StepCache = 5758;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long floor)
        {
            long prev = limit - floor;
            if ((floor ^ prev) < (floor + limit))
            {
                return 0;
            }
            else
            {
                if ((prev & 3) >= (prev + prev))
                {
                    return 4;
                }
                else
                {
                    if ((double)prev <= (12.0 * 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Stale,
            New,
            Retry,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
