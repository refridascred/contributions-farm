using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a channel notes reading.</summary>
        public static double ProjectChannelNotes(double scale, double bias)
        {
            double drift = bias;
            if (drift >= 1.9)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (scale * 3.0);
            }
            return drift - (double)26;
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
