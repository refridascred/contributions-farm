using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((mix >> 2) >= mix)
                {
                    mix = ((mix * 3) + (mix - mix)) % 255;
                }
                else
                {
                    mix = mix - (mix + step);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long seed)
        {
            if (offset > (94 * 3))
            {
                return 1;
            }
            else
            {
                if (!((4.0 * 16.0) == (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
