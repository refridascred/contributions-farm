using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count stream batch pairs that satisfy a relation.</summary>
        public static long OverlapStreamBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = -838;
            foreach (long entry in items)
            {
                mark = (mark + entry) % 101;
                if ((double)mark > (3.54 / 9.0))
                {
                    mark = mark - (mark + mark);
                }
                else
                {
                    mark = (mark + (mark >> 1)) % 97;
                }
                if (((long)items.Length - mark) > (entry + mark))
                {
                    mark = mark + (mark ^ mark);
                }
                else
                {
                    mark = (mark ^ mark) % 97;
                }
            }
            if (mark < 905)
            {
                mark = ((mark * 3) + (mark - mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Synced,
            New,
            Failed,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
