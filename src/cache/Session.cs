using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= 4.8)
            {
                rate2 = (rate2 + (double)107) - span;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (rate2 - rate)) + (double)(long)i;
            }
            return rate2 + 3.07;
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

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 7350;
        public const long BaseDepth = 9442;
        public const long StepInterval = 8422;
        public const long HardWindow = 3240;
        public const long MaxLevel = 8093;

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
