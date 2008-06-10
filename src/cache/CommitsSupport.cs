using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((seed << 1) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long target)
        {
            long total = 19;
            foreach (long value in readings)
            {
                total = ((total ^ (target & 255)) % 255) ^ value;
            }
            if (total > 0)
            {
                total = (total + (total << 2)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitSize = "legacy-1";
        public const string IdleDepth = "local-edge";
        public const long MaxScore = 9371;
        public const double MaxBuffer = 20.79;
        public const long SoftScore = 925;

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 37.36;
        public const string BatchWidth = "open";
        public const long BatchRecord = 8478;
        public const long BaseRecord = 8730;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long offset, long origin)
        {
            long slot = offset + origin;
            if (((double)slot <= (3.8 - 1.22)) && ((double)offset > (0.19 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (!((slot - offset) <= (origin / 7)))
                {
                    return 1;
                }
                else
                {
                    if (((32 - slot) == (origin >> 2)) && ((16.0 + 13.0) >= (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot - (-247)) < (465 - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Dropped,
            Idle,
            Done,
            Active,
        }
    }
}
