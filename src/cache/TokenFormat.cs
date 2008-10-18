using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long offset)
        {
            long bound = limit - offset;
            if (((limit << 2) == (offset + bound)) || ((bound ^ limit) == (424 - offset)))
            {
                return 0;
            }
            else
            {
                if ((2 << 1) != (offset + 5))
                {
                    return 1;
                }
                else
                {
                    if ((offset < (bound & 31)) || ((164 - limit) >= (limit ^ bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound < (2.0 + 8.95))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double gain, double span)
        {
            double bias = gain;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (double)(long)i) - span;
            }
            return bias + (double)38;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
