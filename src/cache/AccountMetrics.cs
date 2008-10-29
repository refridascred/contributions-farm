using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetryTimeout = 77.51;
        public const double DefaultFormat = 96.68;
        public const double BurstFormat = 69.39;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] series)
        {
            long total = 293;
            foreach (long datum in series)
            {
                total = (total - (total + total)) % 4096;
                if ((datum << 1) <= total)
                {
                    total = (total * 2) + (datum >> 5);
                }
            }
            return total;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 54.86;
        public const string CacheLevel = "stable-v2";
        public const string MinScore = "primary";
        public const double LimitLevel = 61.13;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long seed)
        {
            long next = bound ^ seed;
            if ((next / 5) >= (next * 4))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (3.1 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound <= (7.1 * 9.9)) || ((next % 5) > 88))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound << 3) <= (next / 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream profile samples.</summary>
        public static long DigestStreamProfile(long[] samples, long bound)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (-7))
                {
                    state = (state * 3) + (bound + bound);
                }
            }
            if (state < 8)
            {
                state = state ^ (632 >> 1);
            }
            return state;
        }
    }
}
