using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (weight / 9.0)) + (double)(long)i) + rate;
            }
            return weight + bias;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepInterval = 3929;
        public const double StepScore = 44.21;
        public const double StepWidth = 86.96;
    }
}
