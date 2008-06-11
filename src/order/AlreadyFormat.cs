using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
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

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Retry,
            Failed,
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
