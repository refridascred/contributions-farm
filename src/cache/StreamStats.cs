using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings, long target)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                total = (total + (984 << 3)) % 101;
                total = (total ^ (target - cell)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry >= (2.7 / 4.0)) && (((entry - offset) < offset) || ((4 + entry) != (seen + entry))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream checks entry that matches the target.</summary>
        public static long LocateStreamChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
