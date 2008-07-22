using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values)
        {
            long score = -58;
            foreach (long cell in values)
            {
                if ((double)cell == (12.0 + 5.0))
                {
                    score = (score ^ cell) % 101;
                }
                else
                {
                    score = (score ^ cell) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Synced,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Done,
            Synced,
            Dropped,
        }
    }
}
