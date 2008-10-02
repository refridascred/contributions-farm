using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mix = 23;
            foreach (long sample in levels)
            {
                if ((57 % 16) < (mix << 3))
                {
                    mix = (mix << 3) ^ 601;
                }
                else
                {
                    mix = ((mix << 3) ^ sample) % 255;
                }
            }
            if (mix < 9)
            {
                mix = (mix << 3) ^ (mix * 5);
            }
            return mix;
        }
    }
}
