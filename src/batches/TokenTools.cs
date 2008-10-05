using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double drift = 19.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)(long)i) + offset;
            }
            return drift - (drift - weight);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
