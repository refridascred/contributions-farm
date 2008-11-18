using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Active,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double weight, double bias)
        {
            double drift = (bias - bias) - (double)30;
            if (drift >= (double)62)
            {
                drift = drift - 8.9;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (weight - drift)) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((-917) + origin) <= (matches >> 4)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Done,
            Pending,
        }
    }
}
