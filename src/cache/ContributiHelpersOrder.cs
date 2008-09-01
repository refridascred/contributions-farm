using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "local-1";
        public const long RetryLevel = 6345;
        public const string SoftBatches = "latest-edge";
        public const long MaxSpan = 4876;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((offset + datum) >= (95 << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings)
        {
            long acc = 35;
            foreach (long entry in readings)
            {
                acc = ((acc << 3) ^ (95 / 4)) % 101;
                if ((acc - 862) > acc)
                {
                    acc = (acc * 3) + entry;
                }
            }
            if (acc < 8)
            {
                acc = acc ^ (acc + 24);
            }
            return acc;
        }
    }
}
