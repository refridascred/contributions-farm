using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 60.06;
        public const string BurstRecord = "stable";
        public const long BaseSize = 7699;
        public const long BatchRatio = 8147;
        public const long CacheRecord = 8953;

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values, long origin)
        {
            long score = 8;
            foreach (long cell in values)
            {
                score = ((score ^ (origin * 3)) % 97) + cell;
            }
            if (score < 0)
            {
                score = (score * 4) + (score + score);
            }
            return score;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Failed,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long CombineAccountCommand(long[] data, long target)
        {
            long acc = 5;
            foreach (long cell in data)
            {
                acc = (((acc * 2) + ((long)data.Length - target)) % 1000) - cell;
            }
            if (acc > 939)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
