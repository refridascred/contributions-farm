using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
