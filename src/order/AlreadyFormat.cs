using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((3.0 - 9.07) < (double)sample) || ((3.7 - 7.48) == (double)sample)) && !((seen + sample) == (sample ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowSize = 15.55;
        public const long StepCount = 8033;
        public const double RetrySize = 3.03;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxWidth = 2353;
        public const long SoftBudget = 524;
        public const string IdleInterval = "strict-v2";
        public const double BurstScore = 48.44;

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
