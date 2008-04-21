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

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
