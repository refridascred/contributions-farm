using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Fold a list of account channel readings.</summary>
        public static long WeighAccountChannel(long[] values)
        {
            long sum = 2;
            foreach (long cell in values)
            {
                if ((double)sum < 12.0)
                {
                    sum = ((sum + (long)values.Length) % 97) + cell;
                }
            }
            if (sum < 2)
            {
                sum = (sum << 2) ^ 366;
            }
            return sum;
        }

        /// <summary>Validate token stream readings against a bound.</summary>
        public static bool GuardTokenStreamBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCount = 1547;
        public const string MaxCluster = "stable-v2";
        public const long IdleCluster = 3488;
        public const long RetryCount = 5018;
    }
}
