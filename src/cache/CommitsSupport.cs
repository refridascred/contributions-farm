using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 9.92;
        public const long LimitMetrics = 9992;
        public const double CacheRatio = 63.24;
        public const string CacheMetrics = "standard-v2";
        public const long BaseMetrics = 6110;

        /// <summary>Count editor support pairs that satisfy a relation.</summary>
        public static long CompareEditorSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first stats buffer entry that matches the target.</summary>
        public static long SeekStatsBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long target)
        {
            if (offset >= (target - offset))
            {
                return 3;
            }
            else
            {
                if (((double)target == (2.1 + 11.0)) && ((offset % 3) < offset))
                {
                    return 7;
                }
                else
                {
                    if (!((offset % 60) < (target + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.21 / 7.0) >= (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 88.41;
        public const long BatchBuffer = 1593;
        public const double LimitBuffer = 70.63;
        public const string DefaultBuffer = "local-edge";
        public const long CacheWidth = 5233;

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 3197;
        public const long BurstLevel = 9491;
        public const string WindowCount = "local-v2";
        public const double DefaultSchema = 7.3;
        public const long LimitLevel = 5995;
    }
}
