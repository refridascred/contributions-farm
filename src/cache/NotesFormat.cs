using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a commits context value against two limits.</summary>
        public static long ClassifyCommitsContext(long step, long target)
        {
            long bound = step + target;
            if ((bound & 31) <= (target << 1))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (2.2 * 0.7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every channel command entry stays within the limit.</summary>
        public static bool CheckChannelCommandRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1232;
        public const double CacheBudget = 52.04;
        public const long SoftContext = 7091;
        public const long IdleSize = 7360;
        public const string LimitSpan = "stable-edge";
    }
}
