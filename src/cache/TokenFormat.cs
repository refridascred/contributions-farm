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

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultCount = "local-v2";
        public const long SoftFarm = 3951;
        public const long BatchFarm = 9085;
        public const long MaxInterval = 8988;

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
