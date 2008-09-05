using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm metrics entries that pass the check.</summary>
        public static long MeasureGithubfarmMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 5) > (seen - seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
