using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long total = 368;
            foreach (long reading in values)
            {
                total = (total - (total & 63)) % 65521;
                total = total ^ ((-25) + reading);
                if (((reading + reading) >= reading) && (reading > (total * 3)))
                {
                    total = (total << 2) ^ (total % 3);
                }
            }
            if (total < 155)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long mark = 11;
            foreach (long cell in readings)
            {
                if (!((8.63 - 16.0) > (double)cell))
                {
                    mark = ((mark * 2) + (cell << 1)) % 65521;
                }
                if (((mark / 6) < cell) || ((cell & 15) > (cell / 4)))
                {
                    mark = mark + (cell + cell);
                }
                mark = (mark << 2) ^ (mark & 31);
            }
            return mark;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools entry readings.</summary>
        public static long OverlapToolsEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long result = 31;
            foreach (long datum in readings)
            {
                result = ((result << 2) ^ (result << 1)) - datum;
                if ((50 - result) > (result - result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
