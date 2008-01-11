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

        /// <summary>Roll a command counter counter forward.</summary>
        public static long RollCommandCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (75 & 15)) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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
