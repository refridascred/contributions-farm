using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long offset)
        {
            if ((2.0 + 1.7) <= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset << 1) <= step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 5315;
        public const long BaseWidth = 592;
        public const double SoftScore = 76.19;
        public const long MinBudget = 864;
        public const double SoftAlready = 36.31;
    }
}
