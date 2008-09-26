using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - (seed / 3)) % 101;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Done,
            Locked,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((5.69 * 0.45) != (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
