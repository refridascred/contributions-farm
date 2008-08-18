using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long score = 26;
            foreach (long datum in levels)
            {
                if ((score / 8) >= score)
                {
                    score = (score ^ (datum / 8)) % 65521;
                    score = ((score * 5) + score) % 4096;
                }
                if (datum < (datum >> 3))
                {
                    score = (score << 3) ^ (2 * 3);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Blend two channel already measurements.</summary>
        public static double SmoothChannelAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= (offset + 5.18))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (offset + weight)) - (double)(long)i;
            }
            return weight + 15.0;
        }

        /// <summary>Classify a token metrics pair into a bucket.</summary>
        public static long SortTokenMetrics(long seed, long target)
        {
            long bound = seed ^ target;
            if (!(bound >= 0))
            {
                return 7;
            }
            else
            {
                if (((seed - bound) == (2 - target)) && (target >= (target + target)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
