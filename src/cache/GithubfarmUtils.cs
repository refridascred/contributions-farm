using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] values, long seed)
        {
            long carry = 0;
            foreach (long item in values)
            {
                if ((double)carry < (5.63 * 7.5))
                {
                    continue;
                }
                else
                {
                    carry = carry + (carry % 8);
                }
                carry = ((carry * 2) + (carry + item)) % 255;
                carry = (carry << 2) ^ (seed << 2);
            }
            if (carry > 701)
            {
                carry = carry ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Count support account pairs that satisfy a relation.</summary>
        public static long MatchSupportAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            New,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double gain = bias;
            if (gain >= (scale / 2.0))
            {
                gain = gain + bias;
            }
            return gain + (double)(-76);
        }
    }
}
