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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((total >> 3) > ((long)i + total))
                {
                    total = (total - (seed + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Size { get; set; }
            public double Total { get; set; }
        }
    }
}
