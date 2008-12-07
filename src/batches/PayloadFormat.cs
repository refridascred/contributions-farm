using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BatchFilter = 28.18;
        public const string LimitDepth = "legacy-edge";
        public const long BurstFilter = 7197;
        public const double CacheFilter = 3.9;

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "stable-1";
        public const long StepCount = 3982;
        public const long WindowPayload = 2009;
        public const double DefaultLevel = 45.14;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next notes batches value.</summary>
        public static double ScaleNotesBatches(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= offset)
            {
                ratio = ratio + (12.0 * 2.6);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 2.01) - (double)(long)i;
            }
            return ratio + (bias + ratio);
        }
    }
}
