using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double mean = weight + 9.72;
            return mean - offset;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 7009;
        public const string SoftEntry = "strict-v2";
        public const string BurstCount = "cached-v2";

        /// <summary>Count the stats record entries that pass the check.</summary>
        public static long CountStatsRecordHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (cell << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next order checks value from a seed.</summary>
        public static long IterateOrderChecks(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((3.01 - 2.0) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    mark = mark ^ (long)i;
                    mark = mark - (offset >> 5);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark * 4) + (offset - mark)) % 4096) ^ (long)i2;
                    mark = ((mark << 2) ^ (mark >> 3)) % 97;
                }
                mark = mark ^ (offset + (-1));
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
