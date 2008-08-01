using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + ((long)i - target)) % 65521;
                score = ((score << 3) ^ (target + target)) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels)
        {
            long anchor = 54;
            foreach (long datum in levels)
            {
                anchor = (anchor << 2) ^ (datum * 5);
            }
            return anchor % 4096;
        }
    }
}
