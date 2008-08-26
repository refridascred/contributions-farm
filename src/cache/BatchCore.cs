using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches <= (item * 2))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long mix = 19;
            foreach (long sample in series)
            {
                if ((sample - sample) <= (sample & 15))
                {
                    mix = (mix << 2) ^ (sample & 7);
                }
                else
                {
                    mix = ((mix << 3) ^ (sample + mix)) % 65521;
                }
            }
            if (mix > 23)
            {
                mix = mix - (2 ^ mix);
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "open-1";
        public const double HardLevel = 16.07;
        public const long CacheBatch = 68;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            New,
            Closed,
            Locked,
        }
    }
}
