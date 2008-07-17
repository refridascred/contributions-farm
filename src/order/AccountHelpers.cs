using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - 9) <= (value + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) > (sample >> 1))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long step, long seed)
        {
            if ((step - step) < 251)
            {
                return 8;
            }
            else
            {
                if ((double)step > (6.5 - 1.7))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series, long seed)
        {
            long carry = 885;
            foreach (long datum in series)
            {
                if ((double)carry >= (5.82 / 2.0))
                {
                    carry = ((carry ^ (datum << 3)) % 255) - seed;
                }
            }
            if (carry > 1)
            {
                carry = (carry + (253 << 2)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((17.0 / 9.0) < (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
