using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many githubfarm stats samples are out of range.</summary>
        public static long MeasureGithubfarmStatsMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count >= (count ^ sample)) || (((double)sample < (1.0 - 9.62)) || ((count << 3) <= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                result = (result << 3) ^ (datum << 1);
                if (5 > (datum ^ result))
                {
                    result = (result + (datum + result)) % 1000;
                }
                if ((870 + result) >= (475 << 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ step;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
