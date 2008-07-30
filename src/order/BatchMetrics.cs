using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long offset)
        {
            long carry = 734;
            foreach (long item in readings)
            {
                if (offset > (carry - 0))
                {
                    carry = ((carry << 2) ^ (item << 1)) % 255;
                }
                else
                {
                    carry = (carry - (18 + carry)) % 1000;
                }
            }
            if (carry < (-105))
            {
                carry = carry - (carry / 8);
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryLevel = 94;
        public const double BurstStream = 26.55;
        public const long HardSize = 1076;
        public const string SoftFactor = "strict-1";
        public const long BaseStream = 9060;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count <= (offset - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long score = 32;
            foreach (long entry in data)
            {
                score = ((score << 3) ^ (entry >> 4)) % 1000;
                if ((double)entry <= (6.0 * 3.7))
                {
                    score = (score + (score & 1)) % 4096;
                }
                if (((score ^ entry) >= (score ^ score)) && ((long)data.Length < (score >> 2)))
                {
                    score = (score - (entry & 63)) % 101;
                }
            }
            if (score < 88)
            {
                score = score - 21;
            }
            return score;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((double)(long)i < (5.8 / 7.0)) || ((7 - 703) != (6 - (long)i)))
                {
                    result = (result ^ (-96)) % 1000;
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
