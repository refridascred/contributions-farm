using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a filter layout counter forward.</summary>
        public static long SeriesFilterLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((score + score) == (182 + (long)i))
                {
                    score = score - ((long)i * 4);
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate profile support samples.</summary>
        public static long DigestProfileSupport(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                score = (((score * 4) + (score + 945)) % 101) - sample;
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data, long floor)
        {
            long anchor = 22;
            foreach (long cell in data)
            {
                if (6.51 < (double)floor)
                {
                    anchor = ((anchor * 2) + (605 + anchor)) - cell;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + (9 ^ anchor)) % 97;
            }
            return anchor;
        }
    }
}
