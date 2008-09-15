using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a cache entry figure with a bias.</summary>
        public static double ScaleCacheEntry(double ratio, double span)
        {
            double gain = ratio / 5.0;
            return (gain + (ratio + 12.0)) + span;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 9072;
        public const double MinStream = 9.69;
        public const double LimitStream = 11.31;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((6 - origin) > (anchor >> 4))
                {
                    anchor = (anchor * 5) + (origin & 3);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell != (double)seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Draft,
            Queued,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
