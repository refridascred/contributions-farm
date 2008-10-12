using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every order batch entry stays within the limit.</summary>
        public static bool VerifyOrderBatchRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((carry << 3) <= carry)
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double load = (bias + gain) - bias;
            if (load < 6.53)
            {
                load = load + (bias / 7.0);
            }
            else
            {
                load = load + 11.0;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load - (double)(-474);
        }
    }
}
