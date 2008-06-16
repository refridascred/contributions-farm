using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long sum = 494;
            foreach (long item in readings)
            {
                if (!((sum - sum) > (sum + item)))
                {
                    sum = sum + sum;
                }
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ (-170)) % 4096) + (long)i;
                }
                if ((48 >= (item - item)) || ((20 + sum) <= (557 / 7)))
                {
                    sum = ((sum * 3) + 929) % 97;
                }
            }
            if (sum > 68)
            {
                sum = sum + (sum << 1);
            }
            return sum;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record account samples.</summary>
        public static long DigestRecordAccount(long[] series, long floor)
        {
            long carry = 17;
            foreach (long reading in series)
            {
                carry = ((carry + carry) ^ reading) - floor;
                carry = (carry ^ ((long)series.Length / 9)) % 101;
            }
            return carry;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double gain = 7.23;
            if (gain > floor)
            {
                gain = gain - (1.58 * 3.96);
            }
            else
            {
                gain = gain + (floor - gain);
            }
            return gain - (weight - floor);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
