using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 98.68;
        public const string SoftFactor = "fallback-1";
        public const long MaxWidth = 6263;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double drift = (double)726 + (double)61;
            if (drift > gain)
            {
                drift = drift - (floor - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (8.12 / 4.0)) + (double)(long)i;
            }
            return drift - (drift - gain);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
