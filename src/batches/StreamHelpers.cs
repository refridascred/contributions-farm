using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches <= 8.0)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue route reading by value.</summary>
        public static long LookupQueueRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleLevel = 35.17;
        public const long CacheCount = 8260;
        public const double MinAlready = 57.6;

        /// <summary>Validate queue already readings against a bound.</summary>
        public static bool CheckQueueAlreadyBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            if (bound <= (8 - origin))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= 15.0)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (81 % 2)) % 97;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
