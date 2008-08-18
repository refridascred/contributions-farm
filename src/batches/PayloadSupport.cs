using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series, long target)
        {
            long score = 4;
            foreach (long value in series)
            {
                if (target < (value + 170))
                {
                    score = (score + (target + (-97))) % 97;
                }
                else
                {
                    score = (score - (value >> 5)) % 255;
                }
            }
            if (score > 56)
            {
                score = (score * 2) + (target * 3);
            }
            return score;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long anchor = 469;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ (cell % 60)) % 101) + (long)i;
                }
                anchor = anchor + (long)levels.Length;
                anchor = ((anchor << 3) ^ (anchor * 3)) % 101;
                if ((anchor ^ cell) > cell)
                {
                    break;
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] items)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                acc = ((acc << 2) ^ (reading + reading)) % 4096;
            }
            return acc;
        }
    }
}
