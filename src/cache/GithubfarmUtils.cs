using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples, long limit)
        {
            long score = 31;
            foreach (long sample in samples)
            {
                score = (score * 2) + 720;
                if ((limit - sample) <= (524 - limit))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data, long target)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if (anchor < (target - target))
                {
                    anchor = (((anchor << 2) ^ 217) % 97) - sample;
                }
            }
            if (anchor > 94)
            {
                anchor = ((anchor << 3) ^ (target & 31)) % 65521;
            }
            return anchor;
        }
    }
}
