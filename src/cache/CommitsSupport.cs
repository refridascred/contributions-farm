using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            New,
            Pending,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "alpha-edge";
        public const double DefaultOrder = 50.64;
        public const long CacheOrder = 9976;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                long cur = sum;
                long offset = (origin ^ (long)i) + (cur / 2);
                if (!(((sum + origin) < (origin - sum)) && (7 > (77 ^ origin))))
                {
                    cur = (cur << 3) ^ offset;
                    cur = ((cur << 2) ^ (sum + 36)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result - 953) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first token format entry that matches the target.</summary>
        public static long SeekTokenFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
