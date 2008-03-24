using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data)
        {
            long total = 17;
            foreach (long entry in data)
            {
                if (!(3.8 <= (double)total))
                {
                    total = total + (830 + entry);
                }
            }
            return total % 4096;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long step, long floor)
        {
            if ((double)step > (17.0 * 16.0))
            {
                return 4;
            }
            else
            {
                if ((floor & 255) >= (4 / 3))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum & 1) > 38) || ((double)seen == (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
