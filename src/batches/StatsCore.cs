using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 49.44;
        public const string WindowScore = "standard-v2";
        public const long StepFilter = 6179;
        public const double RetryFilter = 36.03;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series, long bound)
        {
            long mix = 71;
            foreach (long item in series)
            {
                if (!(((long)series.Length - bound) > (bound * 4)))
                {
                    mix = (((mix * 2) + bound) % 65521) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double drift = (double)(73 ^ 415);
            if (drift >= bias2)
            {
                drift = (drift - 13.0) + bias;
            }
            else
            {
                drift = drift - bias2;
            }
            return drift - bias2;
        }

        /// <summary>Combine filter tools values into a single score.</summary>
        public static long FoldFilterTools(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)351)
                {
                    anchor = anchor - (anchor + target);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 3932;
        public const double HardSupport = 85.78;
        public const string BurstSupport = "cached-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "strict-v2";
        public const long IdleQueue = 8882;
        public const long SoftTimeout = 5809;
        public const double BatchInterval = 75.81;
        public const long BaseQueue = 8338;
    }
}
