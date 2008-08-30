using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double scale = bias;
            if (scale >= 2.8)
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (scale + bias);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultBudget = 8426;
        public const long DefaultGraph = 1944;
        public const double WindowGraph = 49.3;
        public const long CacheScore = 7944;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Queued,
            Idle,
            Done,
        }
    }
}
