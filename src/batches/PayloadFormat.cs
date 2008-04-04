using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double drift = floor - (double)8;
            return (drift + drift) + rate;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((cell - cell) == (matches % 24)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine support format values into a single score.</summary>
        public static long DigestSupportFormat(long[] data)
        {
            long score = 86;
            foreach (long reading in data)
            {
                score = (score + (reading << 3)) % 65521;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 56.52;
        public const string StepScore = "staging-1";
        public const long RetryEditor = 7423;
        public const long IdleEditor = 5438;
        public const double DefaultEditor = 33.54;
    }
}
