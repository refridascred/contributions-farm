using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long DeriveCommitsMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ (limit / 2)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(163 >= reading) && ((790 ^ reading) != (matches % 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
