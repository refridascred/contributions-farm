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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
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
