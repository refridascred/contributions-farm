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

        /// <summary>Find the first record route entry that matches the target.</summary>
        public static long LocateRecordRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
