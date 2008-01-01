using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (4.3 / 8.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitBudget = 1048;
        public const long CacheCount = 7986;
        public const long LimitTools = 7690;
    }
}
