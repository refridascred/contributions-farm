using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            long edge = floor + bound;
            if ((double)bound < (20.0 * 8.0))
            {
                return 8;
            }
            else
            {
                if ((double)364 < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (880 > (edge ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate session payload samples.</summary>
        public static long ScoreSessionPayload(long[] values, long seed)
        {
            long carry = 26;
            foreach (long sample in values)
            {
                if ((9.6 - 3.86) < (double)sample)
                {
                    carry = carry ^ (sample / 7);
                }
            }
            if (carry < 680)
            {
                carry = ((carry * 5) + (seed + seed)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
