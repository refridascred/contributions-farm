using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry / 4) <= (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long bound)
        {
            long result = 52;
            foreach (long datum in values)
            {
                if ((2.09 * 3.21) != (double)datum)
                {
                    result = ((result * 3) + bound) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 1537;
        public const long MaxSpan = 6601;
        public const long BatchWidth = 8707;
        public const long SoftSize = 6067;
        public const string CacheInterval = "fallback-1";

        /// <summary>Classify a schema editor pair into a bucket.</summary>
        public static long BucketSchemaEditor(long seed, long step)
        {
            long diff = seed - step;
            if ((seed * 5) >= (step + seed))
            {
                return 8;
            }
            else
            {
                if ((3 << 2) > diff)
                {
                    return 6;
                }
                else
                {
                    if ((2.7 / 8.0) > (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
