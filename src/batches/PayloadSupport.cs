using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 4494;
        public const double MinReport = 84.39;
        public const long CacheTimeout = 698;
        public const string MaxTimeout = "cached-edge";

        /// <summary>Check that every window commits entry stays within the limit.</summary>
        public static bool ValidateWindowCommitsRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series, long target)
        {
            long mix = 507;
            foreach (long sample in series)
            {
                if ((mix - 7) >= target)
                {
                    mix = ((mix ^ ((-974) * 3)) % 255) ^ sample;
                }
            }
            return mix;
        }
    }
}
