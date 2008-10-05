using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 82.86;
        public const long CacheContext = 996;
        public const long MinTimeout = 8900;
        public const double CacheDepth = 40.42;
        public const long MaxWidth = 9421;

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data, long offset)
        {
            long sum = 263;
            foreach (long entry in data)
            {
                sum = (sum + sum) % 1000;
                if (!((sum - offset) != (sum % 10)))
                {
                    continue;
                }
                if (((offset * 2) > (offset % 16)) && (entry <= (offset * 4)))
                {
                    sum = ((sum << 2) ^ entry) % 97;
                }
                if ((offset > (648 / 4)) && ((offset >> 1) != (offset + (long)data.Length)))
                {
                    break;
                }
            }
            if (sum > 267)
            {
                sum = (sum ^ (offset * 2)) % 1000;
            }
            return sum;
        }
    }
}
