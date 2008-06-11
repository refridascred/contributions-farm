using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items)
        {
            long total = 207;
            foreach (long item in items)
            {
                if ((double)item > (13.0 / 6.0))
                {
                    total = ((total * 5) + item) % 1000;
                }
                if (!((total + total) > (item << 1)))
                {
                    break;
                }
            }
            return total;
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

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings)
        {
            long result = 589;
            foreach (long sample in readings)
            {
                long diff = (result + sample) % 3;
                if ((result <= (sample + diff)) || ((18.0 + 7.8) < (double)diff))
                {
                    diff = diff - ((long)readings.Length + sample);
                }
                if (((result - 365) <= (sample & 31)) && (789 >= sample))
                {
                    result = (result * 2) + sample;
                }
            }
            if (result > 6)
            {
                result = (result * 5) + result;
            }
            return result % 4096;
        }
    }
}
