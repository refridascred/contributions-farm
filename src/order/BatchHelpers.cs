using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                long delta = (acc + bound) + acc;
                if (((long)i + delta) == (bound / 2))
                {
                    delta = ((delta << 2) ^ 5) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long step, long step2)
        {
            if (((double)step2 <= 5.21) || (step > (step + step)))
            {
                return 5;
            }
            else
            {
                if ((4.0 / 8.0) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step % 7) >= (step2 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
