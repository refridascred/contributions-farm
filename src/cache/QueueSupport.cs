using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "primary-1";
        public const long MaxTimeout = 7153;
        public const long BaseDepth = 6597;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a batches report pair into a bucket.</summary>
        public static long GradeBatchesReport(long step, long limit)
        {
            long diff = step ^ limit;
            if (step >= (step * 5))
            {
                return 5;
            }
            else
            {
                if (17.0 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)diff <= (3.91 * 6.3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
