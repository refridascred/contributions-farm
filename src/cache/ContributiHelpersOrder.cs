using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double scale = gain * 6.8;
            if (scale <= offset)
            {
                scale = scale - (double)818;
            }
            return scale - offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 293;
        public const long LimitCache = 7529;
        public const double MinCache = 95.01;
        public const string BaseSpan = "stable";
        public const long MaxFactor = 7778;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
