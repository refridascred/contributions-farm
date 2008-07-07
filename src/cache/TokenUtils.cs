using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 9057;
        public const double WindowProfile = 70.78;
        public const long LimitWidth = 5225;
    }
}
