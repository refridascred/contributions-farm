using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
