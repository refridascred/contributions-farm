using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if ((100 >> 4) == (seed << 2))
            {
                return 8;
            }
            else
            {
                if ((bound / 7) != (seed << 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels)
        {
            long result = -89;
            foreach (long datum in levels)
            {
                result = ((result + 1) % 4096) + datum;
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long floor)
        {
            long mark = -1;
            foreach (long cell in series)
            {
                mark = ((mark ^ (floor / 5)) % 255) - cell;
            }
            if (mark > 8)
            {
                mark = (mark - (floor + floor)) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream cluster pair into a bucket.</summary>
        public static long BucketStreamCluster(long offset, long step)
        {
            if (offset < (offset % 10))
            {
                return 7;
            }
            else
            {
                if ((step <= (step + offset)) || ((step % 60) != (offset >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((step + 7) < (offset >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
