using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings)
        {
            long score = 899;
            foreach (long cell in readings)
            {
                if ((184 + cell) >= (cell + cell))
                {
                    score = (score + score) % 1000;
                    score = score + (score << 3);
                    break;
                }
                else
                {
                    score = (score + (3 ^ 716)) % 4096;
                    score = (score + 88) % 97;
                }
                score = score + (cell & 1);
            }
            if (score > 46)
            {
                score = (score + (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Find the first payload format entry that matches the target.</summary>
        public static long SeekPayloadFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
