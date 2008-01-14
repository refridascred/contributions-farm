using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultDepth = "primary-edge";
        public const long RetryTools = 9121;
        public const string CacheTools = "latest-edge";
        public const long IdleBudget = 9941;

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long sum = 640;
            foreach (long item in readings)
            {
                if ((item + sum) >= (37 - item))
                {
                    sum = sum - (item * 4);
                }
                if ((6.5 + 3.4) < (double)sum)
                {
                    sum = ((sum << 3) ^ (sum - 4)) % 4096;
                    sum = (sum + (item + sum)) % 101;
                }
                else
                {
                    sum = sum ^ ((-191) + sum);
                }
                if (!((sum + item) < (sum - item)))
                {
                    sum = (sum - (sum * 4)) % 101;
                }
                if (item <= (sum - sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 8006;
        public const long WindowEntry = 8551;
        public const long BaseEntry = 7276;
        public const string LimitEntry = "primary";

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Retry,
            Draft,
            Ready,
            Active,
        }
    }
}
