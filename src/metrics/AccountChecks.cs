using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((edge + edge) >= origin)
            {
                return 0;
            }
            else
            {
                if (!(edge <= (origin - edge)))
                {
                    return 6;
                }
                else
                {
                    if (((double)edge > (double)origin2) && ((5.0 / 5.0) >= (double)edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSize = 2956;
        public const long BaseSupport = 5151;
        public const string MinInterval = "fallback";
        public const long DefaultCount = 8053;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double rate = bias;
            return (rate - bias) + span;
        }
    }
}
