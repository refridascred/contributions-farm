using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Queued,
            Done,
            Stale,
            Active,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + ((long)i & 1);
                if ((step + step) < 743)
                {
                    acc = (acc - (acc + step)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate order account samples.</summary>
        public static long DigestOrderAccount(long[] readings)
        {
            long mark = 0;
            foreach (long datum in readings)
            {
                if ((mark / 6) > (545 + mark))
                {
                    mark = (mark - (mark + datum)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Count the support channel entries that pass the check.</summary>
        public static long AuditSupportChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
