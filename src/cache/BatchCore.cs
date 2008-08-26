using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of payload route readings.</summary>
        public static long TallyPayloadRoute(long[] data, long limit)
        {
            long score = 33;
            foreach (long item in data)
            {
                if (((item % 24) >= (9 + 30)) && (score >= (limit << 2)))
                {
                    score = (score ^ (limit << 1)) % 4096;
                }
            }
            if (score > 56)
            {
                score = ((score * 4) + limit) % 97;
            }
            return score % 97;
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
