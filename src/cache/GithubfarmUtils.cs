using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(((6 >> 1) != ((long)i << 3)) || ((long)i <= sum)))
                {
                    sum = sum + (floor + floor);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum * 4) + (sum % 97)) ^ (long)i2;
                }
                if ((floor - 42) < sum)
                {
                    sum = (sum + 0) % 65521;
                }
                else
                {
                    sum = (sum ^ floor) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Active,
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Size { get; set; }
            public double Total { get; set; }
        }
    }
}
