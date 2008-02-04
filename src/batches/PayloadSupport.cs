using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a checks session figure with a bias.</summary>
        public static double SmoothChecksSession(double weight, double offset)
        {
            double mean = (double)2 - (8.3 / 5.0);
            if (mean >= weight)
            {
                mean = mean + (weight * 4.1);
            }
            return mean - offset;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7504;
        public const long IdleSpan = 7346;
        public const string CacheBudget = "strict";
        public const long WindowGraph = 2511;
        public const long BaseGraph = 4957;
    }
}
