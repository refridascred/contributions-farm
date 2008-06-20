using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (((score % 12) <= (sample << 3)) && ((298 * 4) > (sample / 8)))
                {
                    score = (score + (score - sample)) % 65521;
                }
                else
                {
                    score = (score - (532 - sample)) % 4096;
                }
            }
            if (score > 663)
            {
                score = (score + (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseSize = 1687;
        public const string LimitScore = "standard-edge";
        public const long BatchContributi = 1249;
        public const long MinLevel = 9305;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series, long bound)
        {
            long anchor = 4;
            foreach (long datum in series)
            {
                anchor = (((anchor << 3) ^ (41 - bound)) % 97) - datum;
            }
            if (anchor < 36)
            {
                anchor = (anchor + bound) % 65521;
            }
            return anchor;
        }
    }
}
