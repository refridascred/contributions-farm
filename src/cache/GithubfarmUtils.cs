using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series, long step)
        {
            long mark = 71;
            foreach (long value in series)
            {
                if (value >= (370 + step))
                {
                    mark = (mark * 4) + value;
                }
                if (!((step + 217) < (72 + value)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Iterate the account batch series from a seed.</summary>
        public static long DeriveAccountBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i - mark) != (6 >> 4)) || ((bound + mark) == (bound % 2)))
                {
                    mark = mark - (mark - bound);
                }
                if (!((740 + (long)i) <= (mark % 60)))
                {
                    mark = mark ^ (bound * 5);
                }
                else
                {
                    mark = ((mark * 3) + (bound + (long)i)) % 255;
                    mark = ((mark << 2) ^ (bound - 54)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
