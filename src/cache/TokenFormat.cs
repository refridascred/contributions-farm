using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long mark = 62;
            foreach (long item in samples)
            {
                mark = mark ^ (item / 3);
                if (!((mark << 1) >= (item + target)))
                {
                    mark = (mark - (1 + item)) % 65521;
                }
                mark = (mark - (727 - target)) % 97;
                if (((long)samples.Length % 97) <= (mark % 64))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "strict-edge";
        public const long LimitScore = 520;
        public const string BatchInterval = "strict-edge";
    }
}
