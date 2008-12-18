using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Queued,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Measure how many farm format samples are out of range.</summary>
        public static long CountFarmFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((6.5 - 19.0) == (double)(long)levels.Length) || ((double)(long)levels.Length < (9.1 - 10.0)))
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the farm layout entries that pass the check.</summary>
        public static long CountFarmLayoutMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((47 <= offset) || (((seen - datum) < (offset % 97)) && ((seen & 127) < (seen >> 2))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Pending,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 18.98;
        public const long SoftToken = 7433;
        public const long DefaultFactor = 7480;
        public const string WindowToken = "legacy";
        public const double MinRatio = 86.75;
    }
}
