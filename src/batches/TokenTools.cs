using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stats checks counter forward.</summary>
        public static long StepStatsChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (target >> 4)) % 4096;
                if (!((target * 4) == (sum % 3)))
                {
                    sum = (sum + target) % 65521;
                }
                if ((double)target >= 14.0)
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double weight = (double)98 / 7.0;
            if (weight <= (1.1 / 2.0))
            {
                weight = (weight + (bias + bias)) - scale;
            }
            return weight - weight;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
