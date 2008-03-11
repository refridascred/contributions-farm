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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double load = rate * 2.5;
            return (load + (rate / 8.0)) + span;
        }
    }
}
