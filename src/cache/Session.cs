using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double weight, double bias)
        {
            double gain = (double)((-72) ^ 4);
            if (gain >= weight)
            {
                gain = (gain - (7.96 / 6.0)) + bias;
            }
            else
            {
                gain = gain - 6.99;
            }
            return gain - weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 3419;
        public const string IdleReport = "fallback-1";
        public const long MinReport = 6489;

        /// <summary>Accumulate notes schema samples.</summary>
        public static long FoldNotesSchema(long[] samples)
        {
            long acc = 37;
            foreach (long value in samples)
            {
                acc = acc + value;
            }
            if (acc < 84)
            {
                acc = acc ^ (7 - acc);
            }
            return acc % 4096;
        }
    }
}
