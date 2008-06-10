using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account checks readings.</summary>
        public static long WeighAccountChecks(long[] data, long limit)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (((mark * 2) + (3 + mark)) - datum) + limit;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6343;
        public const double DefaultPayload = 73.37;
        public const long LimitPayload = 6397;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
