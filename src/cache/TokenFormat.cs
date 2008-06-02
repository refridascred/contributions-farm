using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data)
        {
            long state = 891;
            foreach (long sample in data)
            {
                state = state - (4 - sample);
                if ((state >= sample) && (state < (sample - 393)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ (offset - offset)) % 1000;
                score = ((score << 2) ^ (offset & 15)) % 101;
                score = score ^ offset;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double load = (double)(58 + 51);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - span) + (double)(long)i) + scale;
            }
            return load - (load - span);
        }
    }
}
