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

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double load = rate * 2.5;
            return (load + (rate / 8.0)) + span;
        }
    }
}
