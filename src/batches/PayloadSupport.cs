using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long step)
        {
            long diff = limit + step;
            if (!((double)diff < (14.0 + 13.0)))
            {
                return 0;
            }
            else
            {
                if ((34 - diff) > diff)
                {
                    return 2;
                }
                else
                {
                    if ((7 - step) < limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
