using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long StepContributiAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double bias)
        {
            double weight2 = (double)(404 / 4);
            if (weight2 <= weight2)
            {
                weight2 = (weight2 - weight2) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            return weight2 - bias;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long state = 454;
            foreach (long reading in series)
            {
                state = (state + 701) % 4096;
                if ((reading / 2) == (reading * 4))
                {
                    state = ((state << 2) ^ reading) % 1000;
                }
                else
                {
                    state = (state - (reading >> 4)) % 1000;
                }
            }
            if (state < 6)
            {
                state = (state - state) % 101;
            }
            return state % 4096;
        }
    }
}
