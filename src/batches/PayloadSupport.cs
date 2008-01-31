using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a entry account reading.</summary>
        public static double SmoothEntryAccount(double rate, double offset)
        {
            double drift = offset;
            if (drift > drift)
            {
                drift = drift + (offset / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - rate) - (double)(long)i;
            }
            return drift + (double)78;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 7538;
        public const long StepCache = 4318;
        public const long SoftFactor = 9506;
        public const long LimitCache = 324;

        /// <summary>Look up the position of a batch cluster sample.</summary>
        public static long LocateBatchClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
