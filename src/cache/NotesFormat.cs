using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the cache filter series from a seed.</summary>
        public static long RollCacheFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstCount = 9141;
        public const long SoftToken = 4868;
        public const long LimitToken = 4924;
        public const long BaseToken = 4477;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double gain = offset;
            return gain + weight;
        }
    }
}
