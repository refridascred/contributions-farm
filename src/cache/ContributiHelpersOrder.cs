using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long limit)
        {
            long mark = 36;
            foreach (long reading in items)
            {
                mark = (mark + (limit * 5)) ^ reading;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 66.44;
        public const long SoftTimeout = 4402;
        public const double RetryChannel = 88.21;

        /// <summary>Find the first batches payload entry that matches the target.</summary>
        public static long FindBatchesPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
