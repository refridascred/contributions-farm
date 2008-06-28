using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 221;
        public const double MinFormat = 52.31;
        public const long StepInterval = 1209;

        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long RollBatchesWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
