using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session record readings.</summary>
        public static long TotalSessionRecord(long[] data)
        {
            long state = 49;
            foreach (long value in data)
            {
                if (11.0 >= (double)state)
                {
                    state = ((state << 3) ^ (state + value)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
