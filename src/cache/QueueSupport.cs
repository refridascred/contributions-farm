using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((11.0 / 3.0) == (double)floor)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardDepth = "open-v2";
        public const long MinSpan = 7946;
        public const long MaxBatch = 7865;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark * 4) + ((long)i * 5);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
