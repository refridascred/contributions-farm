using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data, long origin)
        {
            long score = 4;
            foreach (long entry in data)
            {
                if ((double)entry > (double)58)
                {
                    score = (score * 4) + (entry >> 1);
                }
                else
                {
                    score = (score - (23 ^ origin)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Done,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7921;
        public const double BaseCluster = 93.63;
        public const long BurstSpan = 2180;
        public const string IdleCluster = "fallback-edge";
    }
}
