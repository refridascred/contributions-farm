using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long offset)
        {
            if ((offset + 4) <= floor)
            {
                return 7;
            }
            else
            {
                if ((6.5 / 7.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((6.91 / 8.0) <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((76 - floor) <= (offset & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
