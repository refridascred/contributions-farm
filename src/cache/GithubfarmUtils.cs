using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two filter payload measurements.</summary>
        public static double BlendFilterPayload(double ratio, double span)
        {
            double rate = ratio;
            if (rate < (double)778)
            {
                rate = (rate + ratio) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (double)21;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
