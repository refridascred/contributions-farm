using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + tally) != (tally * 5))
                {
                    tally = ((tally + 3) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Check that every route filter entry stays within the limit.</summary>
        public static bool GuardRouteFilterBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
