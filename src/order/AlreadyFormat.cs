using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up window context samples.</summary>
        public static long OverlapWindowContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long state = 219;
            foreach (long sample in levels)
            {
                if (sample > (sample - sample))
                {
                    state = ((state << 2) ^ (sample - state)) % 255;
                }
                if ((sample - state) < (sample + state))
                {
                    state = (state ^ ((-1) + (long)levels.Length)) % 4096;
                }
                else
                {
                    state = (state << 3) ^ (state + 139);
                }
            }
            if (state < 21)
            {
                state = ((state * 5) + (state >> 2)) % 255;
            }
            return state;
        }

        /// <summary>Adjust a notes order reading.</summary>
        public static double AdjustNotesOrder(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias * 1.9))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + weight;
            }
            return bias2 - (double)56;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long AuditFilterAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading << 3) < (0 - 675))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
