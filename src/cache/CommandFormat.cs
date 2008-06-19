using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] levels, long step)
        {
            long score = 3;
            foreach (long value in levels)
            {
                if ((20.0 - 3.0) == (double)step)
                {
                    score = (score + (score ^ score)) ^ value;
                }
            }
            if (score < 2)
            {
                score = (score - 633) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryCount = "legacy-edge";
        public const double RetryLayout = 44.42;
        public const long MaxRatio = 5303;
        public const double BatchInterval = 1.81;

        /// <summary>Blend two batch route measurements.</summary>
        public static double SmoothBatchRoute(double gain, double offset)
        {
            double drift = (double)(7 << 2);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + gain) - (double)(long)i) - offset;
            }
            return drift - 2.9;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Retry,
            Done,
        }
    }
}
