using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = (state + ((long)i % 24)) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long mix = -11;
            foreach (long sample in levels)
            {
                mix = (mix - (mix % 5)) ^ sample;
            }
            return mix;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (((mark * 3) + (mark * 4)) % 65521) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
