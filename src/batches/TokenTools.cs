using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metric already input into a small class.</summary>
        public static long BucketMetricAlready(long target, long seed)
        {
            if (seed > (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((4.3 / 6.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double weight2 = (weight / 9.0) * 4.43;
            if (weight2 <= weight2)
            {
                weight2 = (weight2 + (weight2 * 1.0)) - span;
            }
            else
            {
                weight2 = weight2 - (weight + 5.86);
            }
            return weight2 - weight2;
        }
    }
}
