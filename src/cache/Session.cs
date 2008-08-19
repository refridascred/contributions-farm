using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((target + (long)series.Length) >= (count ^ count)) && ((6 << 2) <= cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long step)
        {
            long step2 = target ^ step;
            if ((step2 << 1) > (step & 31))
            {
                return 5;
            }
            else
            {
                if (((step << 2) < step) || ((double)target == (18.0 * 0.9)))
                {
                    return 0;
                }
                else
                {
                    if ((9.1 - 3.4) <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "alpha";
        public const long HardRatio = 7386;
        public const long DefaultScore = 8271;
        public const long MinStream = 4276;
    }
}
