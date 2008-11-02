using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum << 3) ^ 3;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if (((carry - carry) >= (sample / 6)) && ((-97) > (sample % 97)))
                {
                    break;
                }
                if (((double)carry > 4.0) || (sample <= (carry / 6)))
                {
                    carry = (carry * 2) + (sample << 3);
                }
            }
            if (carry < 6)
            {
                carry = ((carry << 2) ^ (carry % 3)) % 65521;
            }
            return carry % 1000;
        }
    }
}
