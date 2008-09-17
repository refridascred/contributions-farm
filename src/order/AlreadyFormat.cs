using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            New,
            Pending,
            Draft,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum / 7) <= (seed + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long limit)
        {
            long edge = target + limit;
            if ((2.0 * 20.0) > (double)edge)
            {
                return 0;
            }
            else
            {
                if (((417 + limit) <= (target ^ edge)) || ((edge << 3) <= target))
                {
                    return 5;
                }
                else
                {
                    if (limit < (limit - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            New,
            Failed,
            Idle,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
