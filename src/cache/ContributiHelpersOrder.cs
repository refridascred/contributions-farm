using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleTimeout = 64.93;
        public const double StepInterval = 14.82;
        public const string LimitLevel = "stable-v2";
        public const string LimitSession = "fallback-1";
        public const double WindowSession = 30.59;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long result = 638;
            foreach (long item in data)
            {
                result = (((result * 2) + (result ^ result)) % 255) - limit;
                if (result <= item)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
