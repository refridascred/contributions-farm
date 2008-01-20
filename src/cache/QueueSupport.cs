using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long sum = 58;
            foreach (long reading in items)
            {
                if ((double)sum >= (double)reading)
                {
                    sum = sum + reading;
                }
                else
                {
                    sum = sum - (sum ^ sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 7482;
        public const long SoftDepth = 3746;
        public const long StepSize = 6772;
    }
}
