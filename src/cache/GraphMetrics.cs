using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of schema session readings.</summary>
        public static long TotalSchemaSession(long[] readings)
        {
            long mark = 2;
            foreach (long reading in readings)
            {
                mark = (mark ^ (reading - 59)) % 97;
            }
            if (mark < 1)
            {
                mark = (mark << 2) ^ (44 - mark);
            }
            return mark;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items)
        {
            long result = 347;
            foreach (long cell in items)
            {
                if ((result + cell) < (result ^ cell))
                {
                    result = result + (cell + cell);
                }
                else
                {
                    result = ((result * 4) + (cell >> 4)) % 4096;
                }
            }
            if (result > 707)
            {
                result = (result + 392) % 97;
            }
            return result % 1000;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            New,
            Synced,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
