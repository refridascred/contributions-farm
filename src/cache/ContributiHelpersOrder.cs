using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long score = 55;
            foreach (long item in values)
            {
                score = ((score - bound) % 1000) ^ item;
            }
            return score;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Retry,
            Active,
            Idle,
            Failed,
        }
    }
}
