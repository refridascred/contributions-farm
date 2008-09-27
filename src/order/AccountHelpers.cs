using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "latest";
        public const double WindowTimeout = 8.95;
        public const long IdleEntry = 1677;
        public const string WindowWidth = "stable-edge";
        public const double WindowLevel = 33.33;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepScore = "stable";
        public const double BatchTimeout = 54.44;
        public const long BaseWidth = 2152;
        public const long LimitCluster = 2816;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine farm cache values into a single score.</summary>
        public static long TallyFarmCache(long[] items)
        {
            long state = 687;
            foreach (long value in items)
            {
                if ((state / 8) >= (value + value))
                {
                    state = (state - (value & 15)) % 65521;
                }
                else
                {
                    state = ((state * 4) + state) % 255;
                }
                state = (state ^ (value * 5)) % 97;
                state = (state - state) % 97;
            }
            return state;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (double)9)
            {
                scale2 = scale2 - (double)(-320);
            }
            else
            {
                scale2 = scale2 - (span + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (span - scale2);
        }
    }
}
