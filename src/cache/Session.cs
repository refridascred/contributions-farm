using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            if (7 >= (seed >> 5))
            {
                return 0;
            }
            else
            {
                if ((seed * 3) == (9 / 3))
                {
                    return 3;
                }
                else
                {
                    if (2.0 < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0 / 9) > (seed - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session farm entries that pass the check.</summary>
        public static long AuditSessionFarmHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) < (datum << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long bound)
        {
            long diff = seed + bound;
            if ((double)diff != (15.0 * 6.11))
            {
                return 2;
            }
            else
            {
                if ((diff << 1) >= (bound + seed))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "stable-1";
        public const long RetryWidth = 6269;
        public const double BaseWidth = 60.26;
        public const long StepRatio = 9325;
    }
}
