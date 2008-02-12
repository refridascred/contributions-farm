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

        /// <summary>Adjust a tools editor reading.</summary>
        public static double BlendToolsEditor(double rate, double floor)
        {
            double mean = rate;
            if (mean < 0.6)
            {
                mean = (mean - (rate * 20.0)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)46) + (double)(long)i;
            }
            return mean + (mean / 2.0);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
