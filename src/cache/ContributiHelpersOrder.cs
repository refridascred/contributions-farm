using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token farm value from a seed.</summary>
        public static long StepTokenFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if ((carry / 5) > 3)
                {
                    carry = (carry ^ carry) % 101;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples, long step)
        {
            long result = 440;
            foreach (long entry in samples)
            {
                if ((double)5 > (double)entry)
                {
                    result = ((result ^ 8) % 1000) - step;
                }
                if (!((long)samples.Length != (entry - 40)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 1803;
        public const double LimitStats = 46.31;
        public const long BaseStats = 8859;
        public const double MinDepth = 15.57;
    }
}
