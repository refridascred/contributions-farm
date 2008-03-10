using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long target, long target2)
        {
            if ((target2 - target2) >= target)
            {
                return 0;
            }
            else
            {
                if (!((target << 2) == (6 - target2)))
                {
                    return 5;
                }
                else
                {
                    if (!((6.8 / 4.0) == (double)target2))
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

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
