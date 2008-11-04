using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long floor)
        {
            long anchor = 2;
            foreach (long sample in levels)
            {
                anchor = ((anchor - (anchor * 2)) ^ sample) - floor;
                if ((38 ^ 786) >= (anchor + 257))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long target)
        {
            if ((double)target <= 5.3)
            {
                return 7;
            }
            else
            {
                if ((target >> 3) < target)
                {
                    return 0;
                }
                else
                {
                    if (((double)step == (4.0 / 3.0)) || ((double)step >= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long TallyClusterCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum < (double)hits) || (((double)datum != (3.75 / 8.0)) && ((39 * 2) < (590 + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultWidth = 36.93;
        public const string IdleScore = "open-v2";
        public const string WindowRatio = "open-1";
        public const long SoftContributi = 2266;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Retry,
            Idle,
        }
    }
}
