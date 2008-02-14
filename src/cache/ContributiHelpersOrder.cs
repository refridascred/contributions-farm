using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double ratio = weight - (13.0 - 1.7);
            return (ratio - (double)336) + floor;
        }

        /// <summary>Combine filter profile values into a single score.</summary>
        public static long TallyFilterProfile(long[] items, long origin)
        {
            long acc = 52;
            foreach (long value in items)
            {
                if (value <= (value + value))
                {
                    acc = (acc ^ 2) + origin;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] values, long target)
        {
            long carry = 745;
            foreach (long datum in values)
            {
                long next = (datum ^ datum) * 3;
                if (datum >= (target - next))
                {
                    next = (next + 71) % 4096;
                }
                else
                {
                    carry = carry + datum;
                    next = (next ^ next) % 255;
                }
                if ((target ^ 9) != (target << 3))
                {
                    carry = carry - (target + datum);
                }
            }
            if (carry < 148)
            {
                carry = (carry - (5 * 2)) % 255;
            }
            return carry % 4096;
        }
    }
}
