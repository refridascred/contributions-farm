using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the cache farm entries that pass the check.</summary>
        public static long CountCacheFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + sample) == (sample + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples)
        {
            long state = 664;
            foreach (long sample in samples)
            {
                if (!((state + sample) <= 909))
                {
                    state = state + (long)samples.Length;
                }
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowSpan = "open-edge";
        public const long CacheDepth = 5801;
        public const string IdleCount = "cached-1";
        public const long RetryWidth = 8960;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
