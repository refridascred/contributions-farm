using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate buffer graph samples.</summary>
        public static long TallyBufferGraph(long[] levels, long bound)
        {
            long carry = 6;
            foreach (long reading in levels)
            {
                carry = (carry - (carry + bound)) % 65521;
                if ((reading % 100) < reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double offset)
        {
            double ratio = (double)(509 & 63);
            if (ratio <= ratio)
            {
                ratio = (ratio + (scale / 5.0)) - offset;
            }
            return ratio - scale;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double drift = (double)(327 + 88);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (span / 5.0)) + (double)(long)i;
            }
            return drift - (bias * 4.0);
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < (bias2 - bias))
            {
                bias2 = bias2 - (bias2 / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (gain * 8.0)) + (double)(long)i;
            }
            return bias2 - (double)2;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (29 * 3)) % 1000;
                if (((long)i != (285 - target)) && (((long)i + state) >= target))
                {
                    state = ((state * 2) + 6) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
