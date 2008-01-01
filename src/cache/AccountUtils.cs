using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long AuditAccountEditorMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum - hits) <= 78)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = (state - 53) % 101;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
