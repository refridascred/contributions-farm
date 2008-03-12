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

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings, long seed)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                mark = ((mark + 0) % 65521) - cell;
            }
            if (mark > 354)
            {
                mark = ((mark << 2) ^ (seed << 1)) % 1000;
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
