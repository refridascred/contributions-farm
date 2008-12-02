using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two cluster notes measurements.</summary>
        public static double BlendClusterNotes(double ratio, double floor)
        {
            double rate = ratio + (double)3;
            if (rate >= ratio)
            {
                rate = (rate + 6.4) - floor;
            }
            return rate + (0.8 - 1.0);
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a layout session counter forward.</summary>
        public static long RollLayoutSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
