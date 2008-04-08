using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Active,
            New,
            Stale,
        }

        /// <summary>Count tools profile pairs that satisfy a relation.</summary>
        public static long MatchToolsProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank support graph input into a small class.</summary>
        public static long ClassifySupportGraph(long seed, long origin)
        {
            long next = seed + origin;
            if ((double)seed != (5.26 - 2.4))
            {
                return 3;
            }
            else
            {
                if ((seed % 5) >= (seed << 1))
                {
                    return 8;
                }
                else
                {
                    if (((seed + 78) != (56 + next)) && ((double)origin < (13.0 + 0.59)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((8.0 <= (double)origin) && (next > (seed * 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
