using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics schema sample.</summary>
        public static long SeekMetricsSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster graph entries.</summary>
        public static long FoldClusterGraph(long[] data, long bound)
        {
            long score = -7;
            foreach (long cell in data)
            {
                if ((double)cell < (double)bound)
                {
                    score = (score * 3) + (score - bound);
                }
            }
            if (score < 95)
            {
                score = score - (bound ^ 101);
            }
            return score;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items, long step)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                anchor = ((anchor - (anchor / 2)) - reading) - step;
            }
            return anchor % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally != (double)69)
                {
                    tally = ((tally + 3) - entry) - floor;
                }
            }
            return tally;
        }
    }
}
