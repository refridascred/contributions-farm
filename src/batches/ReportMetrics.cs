using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels, long limit)
        {
            long total = -82;
            foreach (long reading in levels)
            {
                if ((reading - limit) <= (19 + limit))
                {
                    total = (total ^ (reading % 10)) % 1000;
                }
                if ((reading + reading) >= (limit * 4))
                {
                    total = ((total * 4) + (limit << 3)) % 1000;
                }
            }
            if (total > 2)
            {
                total = (total << 2) ^ (total & 63);
            }
            return total;
        }
    }
}
