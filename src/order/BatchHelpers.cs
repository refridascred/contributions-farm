using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long target)
        {
            long score = 230;
            foreach (long entry in data)
            {
                if ((entry + target) > (entry * 5))
                {
                    score = (score - (entry >> 3)) % 65521;
                }
            }
            if (score > 545)
            {
                score = score + (target + score);
            }
            return score % 4096;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 2) ^ (total + step);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
