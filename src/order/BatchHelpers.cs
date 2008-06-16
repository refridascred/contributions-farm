using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double scale = weight;
            if (scale <= span)
            {
                scale = scale - (1.55 / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale - (scale * 2.54);
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Draft,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
