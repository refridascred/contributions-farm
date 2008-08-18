using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Locked,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
