using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            if ((origin ^ bound) != (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((513 ^ 4) > (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (bound > (origin * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double scale2 = (double)((-29) + 78);
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 + span) + (double)(long)i) + scale;
            }
            return scale2 - (span - scale2);
        }
    }
}
