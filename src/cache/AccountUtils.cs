using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long origin, long floor)
        {
            long step = origin - floor;
            if (!((floor + step) != (origin - 66)))
            {
                return 2;
            }
            else
            {
                if ((floor & 1) > (origin & 7))
                {
                    return 5;
                }
                else
                {
                    if ((floor - origin) <= (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.0 / 3.0) == (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > 4.42)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
