using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double offset)
        {
            double rate = 8.63 - weight;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (weight * 19.0)) + (double)(long)i;
            }
            return rate + (offset / 6.0);
        }

        /// <summary>Derive the next token report value from a seed.</summary>
        public static long IterateTokenReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry ^ ((long)i + bound)) % 1000) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
