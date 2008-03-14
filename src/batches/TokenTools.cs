using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long result = 938;
            foreach (long datum in values)
            {
                result = ((result - (result % 97)) + datum) + origin;
            }
            return result;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long score = 380;
            foreach (long value in samples)
            {
                score = score - (score ^ score);
                if ((value + score) <= (8 ^ value))
                {
                    score = score + (score << 3);
                }
            }
            if (score < (-43))
            {
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score + (score % 12)) % 255) ^ (long)i2;
                    score = (score - (limit - score)) % 4096;
                }
                score = (score ^ (limit << 3)) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
