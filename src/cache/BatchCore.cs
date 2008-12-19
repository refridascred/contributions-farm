using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long bound)
        {
            long state = -7;
            foreach (long datum in series)
            {
                state = ((state - (9 >> 1)) % 101) + bound;
                if ((datum ^ datum) < state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema record entries that pass the check.</summary>
        public static long CountSchemaRecordHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - count) < 1)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                long matches = (mark << 1) * 4;
                if ((offset + mark) < (offset + matches))
                {
                    mark = ((mark * 2) + (matches >> 4)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
