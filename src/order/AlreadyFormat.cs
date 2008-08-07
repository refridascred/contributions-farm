using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Retry,
            New,
            Pending,
            Locked,
        }

        /// <summary>Rank batch cache input into a small class.</summary>
        public static long GradeBatchCache(long limit, long limit2)
        {
            if (limit2 >= (limit2 + limit))
            {
                return 4;
            }
            else
            {
                if (((limit ^ limit2) < limit) && (2.58 >= (double)limit2))
                {
                    return 2;
                }
                else
                {
                    if ((limit + 2) == (limit - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 92.82;
        public const long WindowSpan = 3049;
        public const double BatchTimeout = 69.72;

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowFactor = "latest-edge";
        public const double BurstDepth = 11.34;
        public const long BaseDepth = 9279;
    }
}
