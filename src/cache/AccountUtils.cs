using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ anchor) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Mode { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
