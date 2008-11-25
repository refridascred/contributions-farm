using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
