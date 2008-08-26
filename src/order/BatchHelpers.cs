using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long state = 4;
            foreach (long entry in series)
            {
                state = state - (entry % 97);
            }
            return state;
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
