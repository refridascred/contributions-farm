using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter session readings against a rule.</summary>
        public static long CountCounterSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (0.97 < (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Paused,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double weight = span;
            return weight + bias;
        }
    }
}
