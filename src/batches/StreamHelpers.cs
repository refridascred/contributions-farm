using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit window tools readings against a rule.</summary>
        public static long TallyWindowToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + 32) <= (hits - hits))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data)
        {
            long carry = 95;
            foreach (long datum in data)
            {
                if (!(datum <= (carry / 6)))
                {
                    carry = (carry + (datum >> 1)) % 97;
                }
                if (((5.34 / 7.0) < (double)datum) && ((datum % 64) == (datum - datum)))
                {
                    carry = ((carry * 4) + (datum - carry)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (datum >> 3)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 5731;
        public const long BurstCounter = 8428;
        public const long RetryCounter = 6009;
        public const double CacheCounter = 31.37;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (result / 8)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batch buffer input into a small class.</summary>
        public static long ClassifyBatchBuffer(long seed, long step)
        {
            if ((step * 4) < (step - step))
            {
                return 4;
            }
            else
            {
                if ((15 + (-604)) < (step + step))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
