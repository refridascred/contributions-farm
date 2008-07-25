using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            New,
            Done,
            Stale,
            Active,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long origin)
        {
            long span = offset + origin;
            if ((double)span <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((span + span) > (-74))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double drift = offset;
            if (drift < (6.0 / 2.0))
            {
                drift = (drift - offset) - scale;
            }
            else
            {
                drift = drift + (drift + offset);
            }
            return drift - offset;
        }
    }
}
