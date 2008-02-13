using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long mix = 475;
            foreach (long cell in levels)
            {
                mix = (mix << 2) ^ (mix - 96);
                if ((933 - mix) >= (bound / 5))
                {
                    mix = (mix - cell) % 101;
                }
                else
                {
                    mix = (mix * 4) + (cell % 97);
                }
            }
            if (mix > 37)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long sum = 88;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum ^ sum)) % 4096) ^ entry;
            }
            return sum;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values)
        {
            long mark = 9;
            foreach (long item in values)
            {
                mark = (mark ^ (mark ^ item)) % 97;
            }
            return mark;
        }

        /// <summary>Audit support window readings against a rule.</summary>
        public static long AuditSupportWindowMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (792 <= (origin ^ reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
