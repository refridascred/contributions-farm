using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (28 > (reading + 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((64 - matches) > 278)
                {
                    matches = ((matches + 1) + datum) + step;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxScore = 6417;
        public const double BaseWidth = 34.97;
        public const long MinBatch = 8731;

        /// <summary>Classify a cluster graph pair into a bucket.</summary>
        public static long RankClusterGraph(long bound, long target)
        {
            if ((bound % 10) >= (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if ((bound >> 4) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (((double)bound > (0.1 * 5.69)) || ((bound + 94) == (58 - target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Match up command entry samples.</summary>
        public static long PairCommandEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
