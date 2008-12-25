using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a buffer support figure with a bias.</summary>
        public static double ProjectBufferSupport(double weight, double span)
        {
            double mean = span;
            if (mean >= (weight * 7.19))
            {
                mean = mean + (span / 8.0);
            }
            return mean + (mean / 6.0);
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Active,
            Idle,
            New,
            Done,
        }
    }
}
