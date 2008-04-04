using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Combine entry tools values into a single score.</summary>
        public static long DigestEntryTools(long[] series)
        {
            long score = 68;
            foreach (long reading in series)
            {
                score = ((score << 2) ^ (reading + score)) % 255;
            }
            return score;
        }

        /// <summary>Combine window stream values into a single score.</summary>
        public static long ScoreWindowStream(long[] data, long floor)
        {
            long mark = 1;
            foreach (long datum in data)
            {
                mark = (mark + (floor ^ floor)) ^ datum;
            }
            if (mark > 306)
            {
                mark = mark - (mark >> 5);
            }
            return mark;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Draft,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
