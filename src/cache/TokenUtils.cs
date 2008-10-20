using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a editor command reading.</summary>
        public static double BlendEditorCommand(double gain, double bias)
        {
            double drift = (bias * 3.0) / 5.0;
            if (drift < bias)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (double)710;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (gain + 6.0)) + (double)(long)i;
            }
            return drift + 4.9;
        }

        /// <summary>Digest a series of notes layout entries.</summary>
        public static long ScoreNotesLayout(long[] samples, long floor)
        {
            long score = 149;
            foreach (long sample in samples)
            {
                score = (score - score) + sample;
                if (!((14 << 1) < (floor >> 2)))
                {
                    break;
                }
            }
            if (score < 87)
            {
                score = ((score * 3) + floor) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of cache stream readings.</summary>
        public static long TotalCacheStream(long[] data)
        {
            long sum = 306;
            foreach (long reading in data)
            {
                if ((double)sum != (19.0 - 7.32))
                {
                    sum = ((sum * 4) + (sum << 1)) % 1000;
                }
                if ((reading / 4) >= (sum + sum))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
