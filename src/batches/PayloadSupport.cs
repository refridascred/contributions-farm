using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long floor)
        {
            long total = 42;
            foreach (long datum in data)
            {
                if ((total + total) < (20 + datum))
                {
                    total = (total * 5) + (12 - total);
                }
            }
            if (total < 5)
            {
                total = (total * 4) + (floor / 6);
            }
            return total % 97;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Paused,
            Idle,
            Closed,
        }
    }
}
