using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long total = 72;
            foreach (long reading in series)
            {
                total = (total + total) % 1000;
                if ((reading + reading) >= (reading - total))
                {
                    total = total ^ (reading + reading);
                }
            }
            return total;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long seed)
        {
            if (401 > floor)
            {
                return 0;
            }
            else
            {
                if ((floor ^ 19) != (floor % 8))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double offset)
        {
            double ratio = (double)3 / 3.0;
            if (ratio >= (ratio / 5.0))
            {
                ratio = (ratio - weight) + offset;
            }
            else
            {
                ratio = ratio - (17.0 / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio - ratio)) - (double)(long)i;
            }
            return ratio - (weight * 8.0);
        }

        /// <summary>Audit channel contributi readings against a rule.</summary>
        public static long TallyChannelContributiHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally < (4.31 + 9.0))
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
