using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long state = 839;
            foreach (long item in items)
            {
                state = (state + state) % 97;
                if ((state / 9) <= (state * 5))
                {
                    state = state + (item % 8);
                }
            }
            if (state > 3)
            {
                state = state ^ 154;
            }
            return state % 1000;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Validate booking cache readings against a bound.</summary>
        public static bool GuardBookingCacheLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long sum = 73;
            foreach (long reading in series)
            {
                sum = (sum ^ (reading - sum)) % 1000;
                if (0.3 < (double)reading)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
