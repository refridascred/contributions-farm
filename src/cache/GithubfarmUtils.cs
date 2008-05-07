using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi queue readings.</summary>
        public static long ScoreContributiQueue(long[] levels)
        {
            long carry = 963;
            foreach (long datum in levels)
            {
                carry = (((carry * 5) + (carry & 15)) % 4096) - datum;
                carry = (carry ^ (carry - (long)levels.Length)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long score = 307;
            foreach (long entry in items)
            {
                if ((double)score < 3.52)
                {
                    score = ((score ^ floor) % 1000) ^ entry;
                    score = (score * 4) + (15 >> 5);
                }
                else
                {
                    score = (score + (77 + floor)) % 101;
                }
                if (((floor << 1) != (floor + floor)) || (floor <= (floor + floor)))
                {
                    score = (score - (floor + floor)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Blend two profile cache measurements.</summary>
        public static double ScaleProfileCache(double bias, double floor)
        {
            double gain = (floor * 19.0) - bias;
            if (gain > (floor * 2.0))
            {
                gain = gain - (bias * 5.1);
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (gain - bias)) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }
    }
}
