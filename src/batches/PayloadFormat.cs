using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series, long target)
        {
            long anchor = 32;
            foreach (long cell in series)
            {
                anchor = ((anchor << 3) ^ (35 >> 4)) % 4096;
                if (!(cell >= (target + cell)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long bound)
        {
            if ((target % 100) != (target / 9))
            {
                return 8;
            }
            else
            {
                if ((bound & 3) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((target + bound) > 71)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (4.0 + 3.62))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items)
        {
            long anchor = 72;
            foreach (long sample in items)
            {
                anchor = anchor ^ (anchor + sample);
                if ((7.3 * 3.0) == (double)anchor)
                {
                    anchor = (anchor * 5) + (anchor * 5);
                }
                if ((sample + sample) != (anchor % 97))
                {
                    anchor = (anchor ^ (anchor + sample)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 4969;
        public const double CacheSpan = 0.05;
        public const double SoftRatio = 91.05;
        public const long BatchNotes = 8104;
    }
}
