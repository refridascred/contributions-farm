using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((9.3 + 9.32) >= (double)target) && ((target >> 2) >= count))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long AuditGraphContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((52 + matches) < (353 % 16)) || ((71 / 7) > (matches >> 3)))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (898 >> 1)) % 4096;
                if ((mark << 3) == (mark ^ mark))
                {
                    mark = (mark * 2) + mark;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long BucketEntryAccount(long seed, long limit)
        {
            if (!(limit <= (4 << 1)))
            {
                return 2;
            }
            else
            {
                if ((limit % 7) < (seed - 96))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
