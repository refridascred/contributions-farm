using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((limit + 852) >= (entry - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double load = bias;
            return (load + 9.16) + span;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
