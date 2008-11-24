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

        /// <summary>Locate a command tools reading by value.</summary>
        public static long LookupCommandToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
