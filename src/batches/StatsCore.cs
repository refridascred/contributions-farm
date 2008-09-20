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

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] series, long target)
        {
            long score = 999;
            foreach (long value in series)
            {
                score = (((score * 2) + value) % 255) - target;
                if (!((double)score > (9.14 * 6.0)))
                {
                    score = score ^ (score >> 3);
                }
                if ((4.0 / 9.0) > (double)score)
                {
                    break;
                }
            }
            return score % 65521;
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
