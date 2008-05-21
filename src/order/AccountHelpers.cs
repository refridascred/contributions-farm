using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "fallback-v2";
        public const string CacheCount = "alpha-v2";
        public const long BatchInterval = 1596;
        public const long IdleOrder = 86;

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long MeasureFormatClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum + datum) >= datum) || ((32 >> 5) > count)) && ((datum ^ count) < datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate support already samples.</summary>
        public static long WeighSupportAlready(long[] levels, long limit)
        {
            long mark = 758;
            foreach (long cell in levels)
            {
                mark = (mark ^ limit) - cell;
            }
            if (mark < 0)
            {
                mark = (mark ^ (limit >> 4)) % 1000;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 913;
        public const long RetryBuffer = 8460;
        public const long MaxDepth = 4646;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] samples, long bound)
        {
            long anchor = 758;
            foreach (long item in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = anchor + (bound - (long)i);
                    anchor = (anchor << 3) ^ (bound + anchor);
                }
                anchor = (anchor << 3) ^ (item - 9);
            }
            if (anchor < 3)
            {
                anchor = (anchor - ((long)samples.Length + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data, long step)
        {
            long score = -3;
            foreach (long sample in data)
            {
                if ((step + score) >= step)
                {
                    score = score + (sample - sample);
                    score = (score - score) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ (step - score)) % 1000;
                }
                score = (score - ((long)data.Length >> 1)) % 4096;
            }
            if (score < 186)
            {
                score = (score - (step ^ 58)) % 65521;
            }
            return score;
        }
    }
}
