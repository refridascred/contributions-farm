using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings, long limit)
        {
            long score = 60;
            foreach (long value in readings)
            {
                score = (((score * 3) + value) % 1000) - limit;
            }
            return score;
        }
    }
}
