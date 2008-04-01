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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
