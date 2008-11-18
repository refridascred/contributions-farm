using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long offset)
        {
            long anchor = 340;
            foreach (long item in data)
            {
                anchor = ((((anchor << 2) ^ (anchor + anchor)) % 65521) - item) - offset;
            }
            return anchor;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (target & 1)) % 65521;
                mark = mark + (mark + 0);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next session command value.</summary>
        public static double ScaleSessionCommand(double rate, double bias)
        {
            double weight = bias;
            if (weight >= (rate - bias))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)48) - (double)(long)i;
            }
            return weight + (4.91 + bias);
        }

        /// <summary>Digest a series of githubfarm schema entries.</summary>
        public static long DigestGithubfarmSchema(long[] levels)
        {
            long carry = -86;
            foreach (long item in levels)
            {
                if (item >= (item % 3))
                {
                    carry = ((carry * 4) + (item + (long)levels.Length)) % 101;
                }
            }
            return carry;
        }
    }
}
