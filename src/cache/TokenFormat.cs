using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every farm cluster entry stays within the limit.</summary>
        public static bool CheckFarmClusterBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] levels)
        {
            long mark = -87;
            foreach (long item in levels)
            {
                mark = (mark ^ mark) % 65521;
                if (!((mark + item) < (mark - item)))
                {
                    mark = (mark << 2) ^ (129 & 63);
                }
            }
            if (mark < 92)
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark % 97;
        }
    }
}
