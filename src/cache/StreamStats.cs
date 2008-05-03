using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Idle,
            New,
            Draft,
            Done,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series)
        {
            long score = 52;
            foreach (long reading in series)
            {
                score = (score ^ (92 % 16)) % 97;
                if ((reading - score) == (score >> 3))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (score ^ datum)) % 65521;
            }
            if (score > 4)
            {
                score = (score ^ (score % 60)) % 101;
            }
            return score;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
