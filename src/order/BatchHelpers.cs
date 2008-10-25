using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultScore = 7584;
        public const double StepWindow = 36.67;
        public const long DefaultWindow = 2558;
        public const string CacheWidth = "cached";

        /// <summary>Derive the next route session value from a seed.</summary>
        public static long RollRouteSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (origin % 2)) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a session report value against two limits.</summary>
        public static long ClassifySessionReport(long origin, long offset)
        {
            long slot = origin ^ offset;
            if (!(((-361) % 16) >= (slot % 10)))
            {
                return 5;
            }
            else
            {
                if (((origin ^ offset) > (origin + 654)) && ((double)origin >= 14.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
