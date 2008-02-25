using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "open-1";
        public const long StepCluster = 8012;
        public const long WindowCluster = 9042;
        public const long MaxCluster = 2335;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((519 ^ 4) != (sample >> 5))
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
