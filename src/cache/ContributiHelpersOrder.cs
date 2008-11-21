using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Iterate the queue batch series from a seed.</summary>
        public static long StepQueueBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed ^ seed) == (seed - seed))
                {
                    break;
                }
                acc = ((acc << 3) ^ ((-23) % 64)) % 4096;
                if ((acc % 24) > (acc * 4))
                {
                    acc = acc - seed;
                    acc = ((acc * 2) + acc) % 4096;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }
    }
}
