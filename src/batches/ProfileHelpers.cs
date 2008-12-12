using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next commits tools value from a seed.</summary>
        public static long DeriveCommitsTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark << 2) ^ (target - mark)) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the stats window entries that pass the check.</summary>
        public static long TallyStatsWindowGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)origin > (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items, long step)
        {
            long anchor = 8;
            foreach (long value in items)
            {
                if (value < (anchor << 2))
                {
                    anchor = ((anchor << 3) ^ (step / 4)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (anchor - step);
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
