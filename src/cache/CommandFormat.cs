using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = result + (result - (long)i);
                result = result - (bound * 2);
                result = (result + bound) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (((lane + 9) == (origin + lane)) || ((2.54 * 2.4) <= (double)lane))
            {
                return 6;
            }
            else
            {
                if (((386 * 3) < origin) || ((double)lane >= (2.08 * 7.69)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
