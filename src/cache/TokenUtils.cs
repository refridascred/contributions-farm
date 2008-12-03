using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long step)
        {
            long gap = seed ^ step;
            if (((744 + step) >= gap) || ((step - (-497)) > (gap / 5)))
            {
                return 4;
            }
            else
            {
                if ((step / 7) == (seed - 26))
                {
                    return 1;
                }
                else
                {
                    if ((double)57 > (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.4 + 0.5) <= (double)gap)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
