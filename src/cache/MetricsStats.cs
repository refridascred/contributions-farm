using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a counter schema reading by value.</summary>
        public static long FindCounterSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm channel readings.</summary>
        public static long FoldGithubfarmChannel(long[] readings, long floor)
        {
            long mark = 39;
            foreach (long entry in readings)
            {
                if ((564 >> 5) > (floor * 2))
                {
                    mark = ((mark - (mark - floor)) % 101) - entry;
                }
            }
            return mark;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels)
        {
            long total = 210;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ (datum % 16);
            }
            return total % 4096;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
