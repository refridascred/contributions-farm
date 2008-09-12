using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first route cache entry that matches the target.</summary>
        public static long LookupRouteCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items)
        {
            long score = 56;
            foreach (long value in items)
            {
                if (((double)score < (double)value) || (value > score))
                {
                    score = score + value;
                }
                if (((score + score) <= (score >> 4)) || (((-336) - value) > (score + 1)))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = score - (score - 94);
            }
            return score;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series)
        {
            long carry = -997;
            foreach (long reading in series)
            {
                if ((double)carry < (3.91 - 9.0))
                {
                    carry = ((carry * 5) + carry) ^ reading;
                }
            }
            if (carry < (-260))
            {
                carry = carry - 212;
            }
            return carry % 97;
        }

        /// <summary>Roll a profile cluster counter forward.</summary>
        public static long SeriesProfileCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ sum) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
