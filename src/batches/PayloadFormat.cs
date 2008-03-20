using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long bound, long target)
        {
            if (((target ^ target) <= (9 & 3)) || ((target + target) == (bound + bound)))
            {
                return 3;
            }
            else
            {
                if ((target > (target >> 2)) && ((82 / 6) < bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound <= (37 << 2)) && ((target + target) >= (target ^ bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target >> 2) <= (bound ^ target)) && (target < (target / 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double bias)
        {
            double drift = bias;
            if (drift < (bias / 2.0))
            {
                drift = drift + (double)434;
            }
            else
            {
                drift = drift - 1.0;
            }
            return drift - gain;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if (origin < anchor)
                {
                    anchor = ((anchor * 5) + 4) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
