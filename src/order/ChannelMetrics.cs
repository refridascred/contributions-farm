using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] levels, long limit)
        {
            long sum = 23;
            foreach (long cell in levels)
            {
                sum = sum ^ (cell >> 1);
                sum = sum ^ (cell / 7);
            }
            if (sum < 6)
            {
                sum = ((sum * 3) + (sum + limit)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
