using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Draft,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cache support entry stays within the limit.</summary>
        public static bool GuardCacheSupportRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
