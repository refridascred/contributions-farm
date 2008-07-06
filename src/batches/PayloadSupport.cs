using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long target)
        {
            if ((origin + 7) == (origin / 5))
            {
                return 1;
            }
            else
            {
                if ((origin + target) > (814 << 2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the context counter entries that pass the check.</summary>
        public static long MeasureContextCounterGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item ^ matches) <= (47 + item))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
