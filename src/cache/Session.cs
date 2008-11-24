using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 >= (12.0 / 7.0))
            {
                gain2 = gain2 + (gain * 0.9);
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + 20.0) + (double)(long)i;
            }
            return gain2 + (9.0 - bias);
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
