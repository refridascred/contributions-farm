using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((seed + seed) <= (long)i))
                {
                    total = (total ^ (long)i) % 255;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + target) % 65521;
                if (((2.2 - 4.0) == (double)target) && ((anchor / 8) < (74 ^ (long)i)))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepDepth = 42.4;
        public const long MaxScore = 9278;
        public const long BurstCommits = 6222;
        public const long MinCommits = 6738;
    }
}
