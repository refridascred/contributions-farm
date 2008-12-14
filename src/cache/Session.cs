using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 9666;
        public const string WindowRatio = "stable-edge";
        public const double CacheCount = 20.5;
        public const string IdleSchema = "legacy-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 4638;
        public const long HardTools = 8478;
        public const string StepTools = "legacy-edge";
        public const string IdleSize = "open-edge";

        /// <summary>Find the first token already entry that matches the target.</summary>
        public static long LocateTokenAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
