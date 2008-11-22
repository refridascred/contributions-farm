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

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
