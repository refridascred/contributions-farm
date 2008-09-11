using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a account queue sample.</summary>
        public static long LookupAccountQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxSpan = 8352;
        public const string RetryInterval = "latest-1";
        public const double BurstLevel = 96.07;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long limit)
        {
            if ((limit % 60) < (target & 63))
            {
                return 6;
            }
            else
            {
                if ((8 >= (limit + 8)) || ((limit & 31) != (6 + limit)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
