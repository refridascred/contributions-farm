using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "standard-edge";
        public const long IdleContext = 9569;
        public const long WindowContext = 6737;
        public const double IdleWidth = 82.84;
        public const double SoftContext = 57.49;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable";
        public const string BatchStream = "stable-v2";
        public const long SoftStream = 2509;
        public const long HardSpan = 3577;

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRatio = 2966;
        public const long BatchDepth = 3722;
        public const double LimitRoute = 33.42;

        /// <summary>Combine payload window values into a single score.</summary>
        public static long TotalPayloadWindow(long[] levels, long origin)
        {
            long state = 5;
            foreach (long sample in levels)
            {
                if (((3.3 / 5.0) == (double)origin) && ((sample << 2) > (sample >> 2)))
                {
                    state = (state ^ (origin << 3)) % 65521;
                }
            }
            return state % 65521;
        }
    }
}
