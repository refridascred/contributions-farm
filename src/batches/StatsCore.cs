using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long target)
        {
            long score = 33;
            foreach (long entry in items)
            {
                if (!((score - entry) == (entry + entry)))
                {
                    score = ((score << 2) ^ (entry % 97)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (target ^ entry)) % 1000;
                }
                if ((1 ^ target) <= (entry << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 9444;
        public const double WindowInterval = 6.3;
        public const double MaxSpan = 9.16;
        public const string IdleProfile = "standard";
    }
}
