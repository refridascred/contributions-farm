using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
                anchor = anchor ^ (anchor - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)offset > (15.0 / 4.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
