using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of route editor readings.</summary>
        public static long TotalRouteEditor(long[] levels, long bound)
        {
            long result = 6;
            foreach (long entry in levels)
            {
                if ((double)entry >= (19.0 + 19.0))
                {
                    result = (result - (bound - result)) % 65521;
                    break;
                }
                if ((double)706 <= (double)entry)
                {
                    result = (result << 2) ^ (entry + bound);
                }
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
