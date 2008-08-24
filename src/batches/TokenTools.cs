using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Active,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + span) - (double)(long)i) - gain;
            }
            return weight + (weight - weight);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double rate = (span / 7.0) - 2.33;
            if (rate <= 20.0)
            {
                rate = (rate - (rate * 1.0)) + bias;
            }
            return rate + span;
        }
    }
}
