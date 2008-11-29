using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine editor checks values into a single score.</summary>
        public static long TotalEditorChecks(long[] data, long bound)
        {
            long acc = 9;
            foreach (long reading in data)
            {
                if (!((reading / 8) <= (acc ^ bound)))
                {
                    acc = ((acc * 5) + ((long)data.Length & 7)) % 65521;
                }
                if (((56 / 5) > (bound / 2)) && ((double)reading == (11.0 - 8.0)))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
            }
            if (acc < 685)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool VerifyRecordCacheBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + seed) % 4096;
                if ((seed % 64) != (anchor >> 1))
                {
                    anchor = ((anchor << 3) ^ seed) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9522;
        public const long BurstAlready = 4551;
        public const long IdleAlready = 6603;
        public const double MaxAlready = 3.35;
        public const long LimitTimeout = 6415;
    }
}
