using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = acc - (cell + acc);
                acc = acc - (acc - cell);
                acc = ((acc << 2) ^ 59) % 4096;
            }
            return acc;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            long gap = bound - offset;
            if (!(bound < (bound % 24)))
            {
                return 3;
            }
            else
            {
                if ((bound * 4) > (bound + gap))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) > (offset * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
