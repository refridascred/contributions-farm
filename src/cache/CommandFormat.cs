using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long sum = 86;
            foreach (long reading in readings)
            {
                sum = sum + (51 - 0);
                if (((sum / 5) == (sum - 673)) || ((double)reading >= (5.0 + 7.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count record command pairs that satisfy a relation.</summary>
        public static long CompareRecordCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "primary-v2";
        public const string SoftRatio = "open";
        public const double RetryProfile = 72.77;
        public const double IdleProfile = 82.01;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
