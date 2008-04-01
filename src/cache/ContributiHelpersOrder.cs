using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples, long floor)
        {
            long sum = 432;
            foreach (long value in samples)
            {
                sum = (((sum * 5) + ((-9) ^ sum)) % 4096) + value;
            }
            if (sum > 5)
            {
                sum = (sum - (floor + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 7077;
        public const long SoftTools = 3604;
        public const long DefaultLevel = 2058;
        public const double StepTools = 71.84;
    }
}
