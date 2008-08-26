using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(((tally + tally) >= (reading / 3)) || ((reading % 64) <= reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long step)
        {
            long mark = 7;
            foreach (long item in readings)
            {
                if (!((step >> 2) > (mark + step)))
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                mark = (mark + (item % 5)) % 1000;
                if ((double)step >= (8.51 + 3.5))
                {
                    mark = mark + (step & 31);
                }
            }
            return mark;
        }
    }
}
