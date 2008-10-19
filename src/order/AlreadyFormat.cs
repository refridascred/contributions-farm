using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits - hits) != (seed ^ sample)) && (336 < (long)samples.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first command checks entry that matches the target.</summary>
        public static long LocateCommandChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
