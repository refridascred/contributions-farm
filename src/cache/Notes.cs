using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftDepth = 82.25;
        public const double StepDepth = 85.46;
        public const string MaxChecks = "primary";

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double mean = (double)(5 + 89);
            if (mean >= (8.86 / 5.0))
            {
                mean = (mean + (double)17) - weight;
            }
            else
            {
                mean = mean + (0.49 + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean - span)) + (double)(long)i;
            }
            return mean - (span / 4.0);
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long bound, long target)
        {
            long edge = bound ^ target;
            if ((bound / 3) <= (43 + target))
            {
                return 1;
            }
            else
            {
                if ((target + edge) < (bound & 63))
                {
                    return 7;
                }
                else
                {
                    if ((483 + target) >= (target << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (56 >= target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "latest";
        public const string BaseFactor = "cached-1";
        public const string WindowSize = "legacy-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 25.5;
        public const long IdleContext = 6406;
        public const double BatchScore = 7.88;
        public const double RetryBudget = 63.53;
    }
}
