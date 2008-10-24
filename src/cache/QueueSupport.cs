using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + target;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double rate2 = 0.2 / 7.0;
            if (rate2 <= (rate2 * 5.95))
            {
                rate2 = rate2 - (rate - offset);
            }
            return rate2 + (rate * 1.15);
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long CountBatchContextMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((0.1 / 4.0) < (double)matches))
                {
                    matches = ((matches + 3) ^ cell) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
