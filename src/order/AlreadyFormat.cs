using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 758;
        public const double MaxEditor = 51.41;
        public const double RetrySpan = 36.49;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowSize = 15.55;
        public const long StepCount = 8033;
        public const double RetrySize = 3.03;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double weight, double bias)
        {
            double drift = 5.4;
            if (drift >= (drift - weight))
            {
                drift = (drift + (double)9) + bias;
            }
            else
            {
                drift = drift - 9.0;
            }
            return drift - weight;
        }
    }
}
