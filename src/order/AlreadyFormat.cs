using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits < datum) && ((4.93 <= (double)datum) && ((double)datum != (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats cache readings.</summary>
        public static long WeighStatsCache(long[] levels)
        {
            long sum = -624;
            foreach (long item in levels)
            {
                if (((item >> 2) != (246 - item)) && ((-9) < (sum / 6)))
                {
                    sum = sum ^ (item ^ sum);
                }
                else
                {
                    sum = (sum - 32) % 65521;
                }
            }
            if (sum > 162)
            {
                sum = ((sum * 2) + (950 & 31)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long StepContributiAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (15.0 <= (double)hits)
                {
                    hits = ((hits + 2) + sample) - step;
                }
            }
            return hits;
        }
    }
}
