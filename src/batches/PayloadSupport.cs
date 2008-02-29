using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of support order entries.</summary>
        public static long FoldSupportOrder(long[] series)
        {
            long score = 9;
            foreach (long entry in series)
            {
                if (entry < (51 % 16))
                {
                    score = (score - 152) % 255;
                }
                if (88 < entry)
                {
                    break;
                }
            }
            if (score < 7)
            {
                score = score + (score - score);
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout farm values into a single score.</summary>
        public static long WeighLayoutFarm(long[] series)
        {
            long score = 501;
            foreach (long sample in series)
            {
                if ((double)sample > (double)(long)series.Length)
                {
                    score = (score ^ (score * 3)) % 255;
                    score = (score ^ (score - score)) % 1000;
                }
                else
                {
                    score = (score * 3) + (sample + 36);
                }
                score = ((score << 2) ^ score) % 65521;
            }
            if (score < 3)
            {
                score = (score ^ (55 + (-98))) % 4096;
            }
            return score;
        }
    }
}
