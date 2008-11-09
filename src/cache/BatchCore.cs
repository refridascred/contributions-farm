using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double bias = 9.1;
            if (bias >= (double)92)
            {
                bias = (bias - (double)733) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (double)717) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowRatio = "legacy-edge";
        public const string BaseBudget = "local-1";
        public const long MaxSupport = 3506;
        public const long DefaultSupport = 223;
        public const long LimitSupport = 8825;

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 9670;
        public const string BaseSchema = "cached";
        public const long WindowFactor = 2357;
        public const string MinSchema = "cached-1";
        public const long StepWidth = 4686;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                long step = limit;
                mark = mark - step;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
