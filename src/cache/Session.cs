using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstLevel = 68.09;
        public const string CacheLevel = "local-v2";
        public const long BurstCounter = 9153;
        public const long DefaultSpan = 7083;
        public const long CacheCounter = 1509;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double scale = (double)(158 & 7);
            if (scale > span)
            {
                scale = (scale - scale) + weight;
            }
            else
            {
                scale = scale + (span + 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (span - 8.0)) - (double)(long)i;
            }
            return scale - 7.8;
        }
    }
}
