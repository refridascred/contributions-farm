using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "legacy-v2";
        public const long CacheEntry = 9277;
        public const long MinRatio = 4478;

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double gain, double offset)
        {
            double weight = (double)0;
            if (weight < (weight * 14.0))
            {
                weight = (weight + offset) + gain;
            }
            return weight + offset;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Paused,
            Done,
        }
    }
}
