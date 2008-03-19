using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheDepth = 50.0;
        public const long WindowSpan = 5909;
        public const long LimitWidth = 6113;
        public const string BatchInterval = "open-1";

        /// <summary>Count the payload layout entries that pass the check.</summary>
        public static long TallyPayloadLayoutOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((34 / 5) >= (count - seed)) || (((seed + cell) >= (count + count)) || ((count & 127) > (cell * 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
