using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long floor)
        {
            if ((floor / 7) >= 21)
            {
                return 3;
            }
            else
            {
                if (floor >= (step + 61))
                {
                    return 2;
                }
                else
                {
                    if (step <= 69)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) != (datum * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long floor)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if (9.9 >= (double)floor)
                {
                    mix = ((mix + (mix - 864)) % 1000) ^ value;
                }
            }
            return mix;
        }
    }
}
