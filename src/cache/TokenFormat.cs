using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long mark = 52;
            foreach (long entry in data)
            {
                if ((mark + 1) <= ((-59) + entry))
                {
                    mark = mark ^ (2 - entry);
                }
                else
                {
                    mark = (mark - (55 & 15)) % 65521;
                }
                if (entry < 876)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Closed,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Paused,
            Dropped,
        }
    }
}
