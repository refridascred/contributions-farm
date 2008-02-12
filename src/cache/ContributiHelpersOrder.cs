using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload batch values into a single score.</summary>
        public static long ScorePayloadBatch(long[] items)
        {
            long carry = 79;
            foreach (long reading in items)
            {
                long gap = (303 / 4) << 1;
                carry = ((carry ^ gap) % 101) ^ reading;
                carry = ((carry * 2) + (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double AdjustFilterEditor(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 < (ratio - 7.64))
            {
                ratio2 = (ratio2 + (2.5 + ratio)) - span;
            }
            else
            {
                ratio2 = ratio2 - 4.23;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + ratio2) - (double)(long)i;
            }
            return ratio2 + (double)8;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWidth = 45.08;
        public const long DefaultLevel = 7584;
        public const long SoftWidth = 2866;
    }
}
