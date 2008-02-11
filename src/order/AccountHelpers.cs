using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a already batches value against two limits.</summary>
        public static long ClassifyAlreadyBatches(long bound, long seed)
        {
            long step = bound - seed;
            if ((seed + step) > (bound / 2))
            {
                return 6;
            }
            else
            {
                if ((double)25 > (double)step)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool GuardEditorChecksRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(tally < 9) && ((55 & 15) > reading))
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double drift = 8.5 - bias;
            if (drift > offset)
            {
                drift = drift + (drift - 0.3);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset / 5.0)) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] samples, long offset)
        {
            long score = 69;
            foreach (long item in samples)
            {
                if ((double)score != (3.03 * 3.69))
                {
                    score = (((score + ((long)samples.Length % 16)) % 1000) - item) - offset;
                }
            }
            return score % 1000;
        }
    }
}
