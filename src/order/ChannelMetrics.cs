using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 2) ^ (floor + floor)) % 101;
                result = (result - (result + result)) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 47;
        public const long BurstReport = 6844;
        public const long MinCount = 8431;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
