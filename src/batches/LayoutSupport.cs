using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 5) < ((-12) - count))
                {
                    count = ((count + 3) ^ sample) - limit;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of farm schema readings.</summary>
        public static long MatchFarmSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                long prev = (606 + 740) / 6;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry + (prev + prev)) % 255) ^ (long)i2;
                }
                prev = (prev - (prev >> 5)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double drift = 8.9 * 1.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift - drift) + (double)(long)i) - scale) - offset;
            }
            return drift - (drift * 8.7);
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
