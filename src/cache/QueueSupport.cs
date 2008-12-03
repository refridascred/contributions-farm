using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < gain)
            {
                ratio = ratio - 2.4;
            }
            else
            {
                ratio = ratio - (double)92;
            }
            return ratio + (double)253;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 6105;
        public const string MinBudget = "cached-v2";
        public const long BaseRatio = 4964;
    }
}
