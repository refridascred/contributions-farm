using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a buffer checks reading by value.</summary>
        public static long LocateBufferChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
