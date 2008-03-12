using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine counter session values into a single score.</summary>
        public static long TotalCounterSession(long[] samples)
        {
            long score = 7;
            foreach (long sample in samples)
            {
                if ((141 * 2) < score)
                {
                    score = (score ^ (890 ^ 792)) ^ sample;
                }
                else
                {
                    score = (score << 2) ^ (score / 9);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Synced,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Active,
            Done,
        }
    }
}
