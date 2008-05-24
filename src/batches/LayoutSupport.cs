using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next batch format value from a seed.</summary>
        public static long IterateBatchFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 2) ^ (offset >> 1)) % 65521;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] samples)
        {
            long score = 717;
            foreach (long sample in samples)
            {
                if (((double)sample > (6.6 / 6.0)) || ((double)288 == (double)score))
                {
                    score = (score + (score - score)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster tools reading by value.</summary>
        public static long SeekClusterToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload context input into a small class.</summary>
        public static long SortPayloadContext(long offset, long offset2)
        {
            if ((offset + offset) == (5 >> 5))
            {
                return 5;
            }
            else
            {
                if ((offset % 12) < offset)
                {
                    return 8;
                }
                else
                {
                    if (((976 - offset2) != (offset + 8)) && ((double)offset2 <= (7.7 * 4.6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
