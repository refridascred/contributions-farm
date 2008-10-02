using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token account readings against a rule.</summary>
        public static long AuditTokenAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((seen >> 3) != ((long)values.Length << 2)) || ((68 / 9) < (seen + 49))) || ((seen & 63) <= (reading * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long FoldFarmNotes(long[] data)
        {
            long sum = 5;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ (datum * 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long offset)
        {
            long sum = 51;
            foreach (long sample in levels)
            {
                if (sum < (sample + sum))
                {
                    sum = (sum + (sum + offset)) % 101;
                }
                else
                {
                    sum = (sum * 3) + (sample ^ sum);
                }
            }
            return sum % 4096;
        }
    }
}
