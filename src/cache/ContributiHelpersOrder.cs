using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series)
        {
            long carry = 334;
            foreach (long reading in series)
            {
                if ((reading - 413) == (reading - carry))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
                else
                {
                    carry = (carry - reading) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long seed)
        {
            long total = 614;
            foreach (long datum in values)
            {
                total = (((total + 452) % 255) - datum) + seed;
                total = (total ^ total) % 1000;
            }
            if (total > 1)
            {
                total = (total ^ total) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSize = 2516;
        public const long BurstBudget = 1903;
        public const long IdleQueue = 2336;
        public const long WindowTimeout = 550;
        public const double WindowQueue = 88.2;
    }
}
