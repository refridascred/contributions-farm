using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 426;
        public const string BatchBudget = "local-1";
        public const long LimitQueue = 5971;
        public const long BurstQueue = 8207;
        public const double HardQueue = 47.24;

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long DeriveStreamAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= (origin >> 3))
                {
                    result = (result + (result ^ result)) % 101;
                    result = (result - ((long)i + origin)) % 97;
                    continue;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first layout payload entry that matches the target.</summary>
        public static long LocateLayoutPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
