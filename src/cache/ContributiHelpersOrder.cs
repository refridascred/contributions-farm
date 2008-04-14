using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long limit)
        {
            long mark = 60;
            foreach (long cell in readings)
            {
                mark = (mark + (5 + 43)) + limit;
                if ((double)cell > 6.0)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long result = -607;
            foreach (long cell in readings)
            {
                result = (((result * 3) + (result % 60)) ^ cell) - offset;
                if ((751 << 3) != (result % 60))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result * 4) + (54 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            if (floor <= limit)
            {
                return 7;
            }
            else
            {
                if (!((double)floor < (3.3 * 7.9)))
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
