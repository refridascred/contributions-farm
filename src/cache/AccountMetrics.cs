using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] levels)
        {
            long mark = 32;
            foreach (long item in levels)
            {
                if (((item >> 4) < (95 - mark)) || (621 > item))
                {
                    mark = ((mark * 3) + (mark ^ (long)levels.Length)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "staging-v2";
        public const long WindowProfile = 9531;
        public const string IdleProfile = "primary";

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target <= (result / 6)) && ((result + result) < (324 ^ result)))
                {
                    result = (result << 3) ^ target;
                    result = ((result * 3) + ((long)i / 6)) % 65521;
                }
                result = (result * 5) + result;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
