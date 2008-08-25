using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long AuditBatchesFarmGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!!(count >= (count >> 1)))
                {
                    count = ((count + 2) - reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings, long step)
        {
            long score = 74;
            foreach (long datum in readings)
            {
                score = ((score - (datum % 8)) % 101) - step;
            }
            if (score < 533)
            {
                score = score + (2 << 2);
            }
            return score % 4096;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Paused,
            New,
            Stale,
            Retry,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long offset, long origin)
        {
            long gap = offset - origin;
            if ((origin + origin) < (gap % 16))
            {
                return 5;
            }
            else
            {
                if (((gap & 255) > (origin << 1)) || ((origin + origin) <= (origin ^ gap)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count stats schema pairs that satisfy a relation.</summary>
        public static long PairStatsSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
