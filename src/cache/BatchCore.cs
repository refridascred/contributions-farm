using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats notes entries.</summary>
        public static long TotalStatsNotes(long[] readings, long bound)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = score - sample;
                score = ((score * 4) + (bound & 7)) % 101;
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool VerifyContributiSessionRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Locked,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Blend two queue contributi measurements.</summary>
        public static double SmoothQueueContributi(double weight, double span)
        {
            double drift = (double)9 * 8.7;
            if (drift < (weight + drift))
            {
                drift = drift + span;
            }
            else
            {
                drift = drift - 6.1;
            }
            return drift - (weight + span);
        }
    }
}
