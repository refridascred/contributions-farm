using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the already account entries that pass the check.</summary>
        public static long TallyAlreadyAccountMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count ^ count) == (8 / 8))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

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
