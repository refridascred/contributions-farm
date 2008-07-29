using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8983;
        public const double MinInterval = 33.57;
        public const long RetryFactor = 7897;
        public const long HardDepth = 5733;
        public const string DefaultReport = "legacy-edge";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first stream metrics entry that matches the target.</summary>
        public static long LookupStreamMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((bound + offset) > edge)
            {
                return 2;
            }
            else
            {
                if ((edge - offset) <= (3 + bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound - 9) != (edge - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(bound > 55))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
