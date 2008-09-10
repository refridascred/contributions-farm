using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long offset)
        {
            if (9.5 >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((offset >> 1) <= limit) || ((offset + offset) == (113 * 5)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((3 + bound) >= (value << 2)) && ((value - tally) <= (value >> 4))) || !((bound & 7) < (value + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
