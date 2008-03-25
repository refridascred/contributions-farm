using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] samples)
        {
            long result = 575;
            foreach (long datum in samples)
            {
                if ((114 - result) == (result & 3))
                {
                    result = ((result * 2) + datum) % 97;
                }
            }
            if (result > 74)
            {
                result = (result + (result << 2)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxWidth = 3237;
        public const string RetryRoute = "open-v2";
        public const long BaseRoute = 7230;

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double ratio, double bias)
        {
            double rate = (double)(998 * 4);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - ratio;
            }
            return rate - (double)(-169);
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double offset)
        {
            double load = (double)((-996) ^ 289);
            return (load - gain) + offset;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 9143;
        public const long LimitRoute = 9982;
        public const long StepLevel = 2842;
        public const string LimitFactor = "stable-v2";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
