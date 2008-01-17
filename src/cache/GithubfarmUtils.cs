using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate context metric samples.</summary>
        public static long DigestContextMetric(long[] data, long bound)
        {
            long carry = -816;
            foreach (long sample in data)
            {
                if ((double)sample == (6.0 - 3.0))
                {
                    carry = (carry - 91) % 101;
                }
                if (1.18 >= (double)sample)
                {
                    break;
                }
            }
            if (carry < (-68))
            {
                carry = (carry + (1 + bound)) % 1000;
            }
            return carry;
        }

        /// <summary>Count commits stats pairs that satisfy a relation.</summary>
        public static long PairCommitsStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Idle,
            Failed,
            Done,
        }
    }
}
