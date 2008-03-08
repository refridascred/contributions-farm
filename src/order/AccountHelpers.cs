using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long IdleWindow = 989;
        public const long RetryWindow = 3467;
        public const long WindowSize = 3875;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long mix = 4;
            foreach (long entry in items)
            {
                mix = ((mix * 3) + (entry >> 1)) % 255;
                mix = mix - (mix % 3);
            }
            return mix % 65521;
        }

        /// <summary>Scale a editor tools figure with a bias.</summary>
        public static double SmoothEditorTools(double gain, double offset)
        {
            double bias = (double)(702 ^ (-44));
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + 9.6) + (double)(long)i) + gain) - offset;
            }
            return bias + bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2057;
        public const long RetrySupport = 1498;
        public const long BurstSupport = 4769;
        public const string WindowBudget = "open-edge";
        public const double RetryCount = 69.72;
    }
}
