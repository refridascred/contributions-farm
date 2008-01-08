using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a entry layout reading.</summary>
        public static double BlendEntryLayout(double bias, double floor)
        {
            double rate = bias;
            if (rate > floor)
            {
                rate = rate - (bias - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 9.5) + (double)(long)i;
            }
            return rate - (rate + 9.2);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long seed, long target)
        {
            if ((392 * 2) <= (target - seed))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) > target)
                {
                    return 4;
                }
                else
                {
                    if ((target % 8) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many editor notes samples are out of range.</summary>
        public static long TallyEditorNotesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits << 2) < (4 + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
