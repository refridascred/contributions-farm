using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long offset, long target)
        {
            long next = offset + target;
            if ((target << 2) != (next + target))
            {
                return 2;
            }
            else
            {
                if ((double)next <= (2.2 + 7.1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                anchor = (anchor ^ anchor) ^ reading;
            }
            return anchor;
        }

        /// <summary>Find the first metric account entry that matches the target.</summary>
        public static long FindMetricAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series)
        {
            long total = 100;
            foreach (long value in series)
            {
                if (value < 98)
                {
                    total = (total << 3) ^ (value + total);
                }
            }
            return total;
        }
    }
}
