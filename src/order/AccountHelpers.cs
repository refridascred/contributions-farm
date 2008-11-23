using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "primary-v2";
        public const double BatchBatches = 49.42;
        public const long BatchTimeout = 395;
        public const string DefaultBatches = "latest-1";
        public const long RetryFactor = 8008;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((0.9 / 3.0) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first profile stream entry that matches the target.</summary>
        public static long SeekProfileStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count << 3) < (reading >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((bound >> 5) > (reading + tally)) && ((reading * 5) >= reading))
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

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
