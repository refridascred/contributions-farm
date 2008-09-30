using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < 4)
                {
                    mark = (mark << 2) ^ limit;
                }
                mark = mark - (limit + limit);
                if ((2.8 * 5.0) == (double)limit)
                {
                    mark = ((mark << 3) ^ (mark + limit)) % 4096;
                    mark = ((mark << 3) ^ (mark + mark)) % 255;
                }
                else
                {
                    mark = (mark + (limit << 1)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long origin2)
        {
            if ((origin << 3) > (654 ^ origin2))
            {
                return 1;
            }
            else
            {
                if ((1.82 * 1.0) > (double)origin2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
