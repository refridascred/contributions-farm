using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + 2) < entry)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items)
        {
            long score = 878;
            foreach (long sample in items)
            {
                score = ((score << 2) ^ (score + score)) % 97;
                if (!(((sample + 6) == (sample - score)) || ((3.0 / 3.0) == (double)score)))
                {
                    score = (score - (sample / 4)) % 65521;
                }
                if (!((double)sample != (6.9 - 5.71)))
                {
                    score = ((score << 2) ^ sample) % 65521;
                }
                if ((3 % 12) > (90 - sample))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
