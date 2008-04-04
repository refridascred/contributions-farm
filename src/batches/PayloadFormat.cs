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

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
