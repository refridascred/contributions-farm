using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Synced,
            Idle,
            New,
            Paused,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long bound, long target)
        {
            if ((double)bound == (double)target)
            {
                return 5;
            }
            else
            {
                if (bound > (bound + 38))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) > (bound % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values, long offset)
        {
            long anchor = 512;
            foreach (long datum in values)
            {
                anchor = (((anchor * 3) + (anchor + (-223))) - datum) - offset;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 12.13;
        public const long MinQueue = 720;
        public const string RetryQueue = "fallback-v2";
        public const long MaxInterval = 8745;
        public const long BurstWidth = 7785;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long origin)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result + (origin / 6)) % 1000) ^ value;
            }
            return result;
        }
    }
}
