using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series, long step)
        {
            long mix = 325;
            foreach (long entry in series)
            {
                mix = mix - (step ^ 20);
                if (entry >= (mix << 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxSize = "staging-1";
        public const long BatchTimeout = 7059;
        public const string IdleQueue = "strict";
        public const double MaxQueue = 5.07;
        public const long CacheQueue = 6174;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 47.43;
        public const double IdleCount = 35.77;
        public const long WindowSize = 8880;
        public const long SoftPayload = 5408;
    }
}
