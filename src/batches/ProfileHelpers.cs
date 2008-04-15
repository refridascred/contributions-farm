using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix - ((long)i - origin)) % 1000;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((limit << 2) == (limit & 3)) || ((6.2 - 5.2) == (double)datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long step)
        {
            long state = 31;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ reading) - step;
            }
            if (state < 6)
            {
                state = state ^ (51 - 1);
            }
            return state;
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long TallyCommitsAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen & 31) < (899 % 16))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a account schema reading by value.</summary>
        public static long SeekAccountSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
