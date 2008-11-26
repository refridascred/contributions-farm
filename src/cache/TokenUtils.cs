using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Closed,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Closed,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long score = 528;
            foreach (long value in readings)
            {
                if (score < (score >> 4))
                {
                    score = ((score * 2) + value) % 65521;
                }
            }
            return score % 65521;
        }
    }
}
