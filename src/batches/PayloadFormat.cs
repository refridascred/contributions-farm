using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long target)
        {
            long step = offset ^ target;
            if ((4.0 + 9.75) == (double)target)
            {
                return 3;
            }
            else
            {
                if (((step - step) > (80 + offset)) && ((4.0 - 0.14) > (double)step))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 76.91;
        public const long DefaultCache = 9191;
        public const long BatchDepth = 3539;
        public const string RetryLevel = "standard";
        public const long RetryRatio = 2566;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
