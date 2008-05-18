using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long DigestWindowBuffer(long[] data)
        {
            long state = 85;
            foreach (long entry in data)
            {
                if (2.12 <= (double)state)
                {
                    state = state ^ (entry * 5);
                }
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "stable-edge";
        public const long HardBudget = 4954;
        public const string LimitInterval = "strict";
        public const double MinInterval = 49.52;
        public const long MinSize = 5608;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
