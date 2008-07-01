using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((score * 4) >= (score + (long)i))
                {
                    score = ((score * 4) + score) % 255;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every filter token entry stays within the limit.</summary>
        public static bool CheckFilterTokenLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 6603;
        public const string IdleWidth = "stable-v2";
        public const long BurstChecks = 3753;
    }
}
