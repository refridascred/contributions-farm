using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long bound, long target)
        {
            if (!(bound >= (target + target)))
            {
                return 4;
            }
            else
            {
                if ((target >> 5) != (target + bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double bias = weight + (double)5;
            if (bias > bias)
            {
                bias = (bias + (bias * 14.0)) - span;
            }
            return bias + (double)4;
        }
    }
}
