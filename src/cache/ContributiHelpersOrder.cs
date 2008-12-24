using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile graph values into a single score.</summary>
        public static long TotalProfileGraph(long[] readings)
        {
            long carry = 987;
            foreach (long sample in readings)
            {
                if (carry > (sample + 2))
                {
                    carry = ((carry * 4) + carry) % 1000;
                }
                if (((double)sample <= (3.2 / 4.0)) && (sample <= ((-551) + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((seed & 3) >= (38 >> 1))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next order batches value.</summary>
        public static double BlendOrderBatches(double rate, double span)
        {
            double load = (double)8 * 10.0;
            if (load >= (double)2)
            {
                load = ((load + (double)2) - rate) - span;
            }
            return load + (load + 5.46);
        }
    }
}
