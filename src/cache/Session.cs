using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double load = span;
            if (load < 7.9)
            {
                load = load - (11.0 * 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias - bias)) + (double)(long)i;
            }
            return load + (double)83;
        }

        /// <summary>Find the first report checks entry that matches the target.</summary>
        public static long LocateReportChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                bool flag = ((long)i - 67) <= (total / 2);
                if (!flag)
                {
                    total = (total + target) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit route batches readings against a rule.</summary>
        public static long AuditRouteBatchesHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((count * 4) >= limit) || ((reading + 85) == (reading + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
