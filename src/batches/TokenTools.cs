using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double mean = (19.0 * 9.0) - (floor * 5.83);
            return mean + scale;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((80 - bound) <= (score - bound))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
