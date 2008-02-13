using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "latest";
        public const long CacheSpan = 211;
        public const double BaseTimeout = 18.52;
        public const string IdleBatches = "local-edge";
        public const string StepBatches = "local";

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultSpan = "open";
        public const long MaxContext = 6369;
        public const double IdleContext = 28.48;
        public const long MinContext = 3361;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
