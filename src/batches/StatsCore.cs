using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first stream buffer entry that matches the target.</summary>
        public static long FindStreamBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (limit >= (matches + 97))
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinScore = 15.3;
        public const long WindowPayload = 3690;
        public const string RetryRatio = "open-v2";
        public const long RetryPayload = 1886;
        public const string CacheBudget = "cached-edge";

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double gain = offset;
            if (gain <= (double)1)
            {
                gain = gain - (weight / 7.0);
            }
            return gain - gain;
        }
    }
}
