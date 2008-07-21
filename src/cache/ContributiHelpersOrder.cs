using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a notes filter figure with a bias.</summary>
        public static double ProjectNotesFilter(double weight, double bias)
        {
            double mean = 8.4;
            if (mean >= bias)
            {
                mean = mean + (mean * 0.81);
            }
            else
            {
                mean = mean + (double)6;
            }
            return mean + (weight - 6.0);
        }

        /// <summary>Check that every stream schema entry stays within the limit.</summary>
        public static bool CheckStreamSchemaRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
