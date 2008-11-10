using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double bias = 3.3;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + bias) + (double)(long)i) + scale;
            }
            return bias - floor;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback-v2";
        public const double HardSize = 28.22;
        public const double WindowInterval = 84.83;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load - bias;
            }
            else
            {
                load = load + (8.0 - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (scale - load);
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Queued,
            Done,
            Draft,
        }
    }
}
