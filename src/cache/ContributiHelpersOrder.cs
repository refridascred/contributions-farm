using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next filter checks value.</summary>
        public static double SmoothFilterChecks(double ratio, double offset)
        {
            double load = 11.0;
            if (load > (double)98)
            {
                load = (load - offset) - ratio;
            }
            else
            {
                load = load + (double)240;
            }
            return load + (double)773;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 44.23;
        public const string RetryOrder = "open";
        public const long WindowOrder = 7778;
    }
}
