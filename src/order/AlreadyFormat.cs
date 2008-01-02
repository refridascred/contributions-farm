using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                long edge = (long)i * 4;
                total = (total * 5) + edge;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit entry record readings against a rule.</summary>
        public static long AuditEntryRecordGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits < (19.0 - 0.4))
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long limit)
        {
            long span = seed - limit;
            if ((span - span) != (limit + limit))
            {
                return 4;
            }
            else
            {
                if (61 >= (limit << 3))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
