using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 8380;
        public const long MaxFormat = 2182;
        public const long SoftFormat = 7850;
    }
}
