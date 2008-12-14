using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            long bound = seed + seed2;
            if (!((seed - bound) >= (bound << 3)))
            {
                return 8;
            }
            else
            {
                if ((bound + seed2) < (seed >> 2))
                {
                    return 2;
                }
                else
                {
                    if (6 >= (seed2 ^ seed2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
