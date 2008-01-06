using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long seed2)
        {
            if ((9.0 / 9.0) == (double)seed2)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > (seed2 - 49))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed2 > (5.0 - 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (1 >= seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Scale a schema stream figure with a bias.</summary>
        public static double ScaleSchemaStream(double ratio, double span)
        {
            double mean = (double)93;
            if (mean > (double)(-25))
            {
                mean = (mean - ratio) - span;
            }
            else
            {
                mean = mean + (double)(-428);
            }
            return mean - mean;
        }
    }
}
