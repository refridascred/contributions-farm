using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Ready,
            Closed,
            Queued,
            Locked,
        }
    }
}
