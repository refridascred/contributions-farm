using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (offset + bias)) - (double)(long)i;
            }
            return scale - (offset - offset);
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double load = scale;
            if (load > (bias - scale))
            {
                load = load - 5.59;
            }
            return load - bias;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Stale,
            Dropped,
            Draft,
        }
    }
}
