using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a format support sample.</summary>
        public static long SeekFormatSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long score = 423;
            foreach (long datum in items)
            {
                score = ((score * 2) + (datum - datum)) % 97;
            }
            if (score > 0)
            {
                score = score - (score % 64);
            }
            return score;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Done,
            Stale,
            Active,
            Draft,
        }
    }
}
