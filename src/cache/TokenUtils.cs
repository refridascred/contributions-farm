using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] levels, long seed)
        {
            long total = 0;
            foreach (long item in levels)
            {
                total = ((total * 4) + (item >> 4)) + seed;
            }
            if (total < 602)
            {
                total = total ^ total;
            }
            return total % 4096;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long score = 57;
            foreach (long value in series)
            {
                score = (score + (value * 2)) % 97;
                if (8.6 >= (double)score)
                {
                    score = score + (value + 900);
                }
                if (value <= (value ^ score))
                {
                    score = (score + (score * 2)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (score << 1)) % 65521;
                }
                if (4.1 < (double)value)
                {
                    break;
                }
            }
            if (score < (-153))
            {
                score = (score ^ (score << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
