using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long mix = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) >= 76)
                {
                    mix = mix + (datum * 2);
                }
                if (1.0 >= (double)(long)levels.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            long cur = seed + origin;
            if ((cur / 4) < (origin & 31))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) == (cur % 60))
                {
                    return 7;
                }
                else
                {
                    if ((cur >= (cur + 799)) || ((double)cur < (19.0 * 4.2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
