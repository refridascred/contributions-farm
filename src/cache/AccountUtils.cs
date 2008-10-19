using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Idle,
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long DigestEntryOrder(long[] levels)
        {
            long mark = 3;
            foreach (long sample in levels)
            {
                if ((mark * 3) > (mark >> 4))
                {
                    mark = mark + (sample / 7);
                }
            }
            if (mark < 87)
            {
                mark = mark + (mark + 30);
            }
            return mark % 65521;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
