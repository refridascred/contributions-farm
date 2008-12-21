using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the graph format series from a seed.</summary>
        public static long RollGraphFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((anchor ^ 4) <= 24)
                {
                    anchor = (anchor * 5) + floor;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 6284;
        public const double BatchProfile = 41.9;
        public const long BurstProfile = 3924;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 66.84;
        public const double MinTimeout = 4.27;
        public const long SoftScore = 5338;
    }
}
