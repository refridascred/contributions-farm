using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first order command entry that matches the target.</summary>
        public static long FindOrderCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 85;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum ^ (sample << 2)) + (long)i;
                }
                if (((long)values.Length <= sum) || ((sample % 5) >= (sum << 1)))
                {
                    sum = (sum - ((-51) + 691)) % 65521;
                }
            }
            if (sum > 80)
            {
                sum = ((sum * 2) + sum) % 4096;
            }
            return sum % 97;
        }
    }
}
