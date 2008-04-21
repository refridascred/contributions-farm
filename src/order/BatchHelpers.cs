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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
