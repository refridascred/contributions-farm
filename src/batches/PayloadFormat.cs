using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)sum < (20.0 - 3.0))
                {
                    sum = ((sum << 3) ^ ((long)i % 24)) % 1000;
                }
                if ((sum & 7) > (long)i)
                {
                    sum = (sum + (sum >> 4)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count <= (count ^ count))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels, long seed)
        {
            long result = 64;
            foreach (long datum in levels)
            {
                if ((result ^ result) > (datum * 2))
                {
                    result = (result - (result / 2)) % 101;
                    result = ((result << 2) ^ (seed >> 4)) % 255;
                }
                if ((double)datum <= (double)(long)levels.Length)
                {
                    result = (result - datum) % 65521;
                }
            }
            if (result > 209)
            {
                result = (result - seed) % 4096;
            }
            return result;
        }

        /// <summary>Rank batch support input into a small class.</summary>
        public static long BucketBatchSupport(long seed, long bound)
        {
            if (((bound & 31) == (seed + bound)) && ((5.5 - 0.3) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if (((1.4 * 0.13) == (double)seed) || ((bound >> 1) > (seed ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (!((4.2 / 2.0) <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.87 * 7.06) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
