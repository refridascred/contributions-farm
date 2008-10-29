using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next batches entry value.</summary>
        public static double SmoothBatchesEntry(double scale, double bias)
        {
            double mean = (scale + 4.1) - (scale + scale);
            return (mean + (double)(-76)) + bias;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 4;
            foreach (long value in levels)
            {
                carry = (carry - 920) % 1000;
                if (((carry << 1) == (value + value)) && ((carry << 2) <= carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
