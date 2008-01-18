using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long sum = 99;
            foreach (long sample in items)
            {
                if (((6.35 * 20.0) < (double)sample) || ((sample * 5) <= (sample ^ sum)))
                {
                    sum = ((sum * 3) + (sample & 1)) % 255;
                }
                else
                {
                    sum = sum ^ sample;
                }
            }
            if (sum < 757)
            {
                sum = (sum - (5 >> 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 9157;
        public const string BatchCounter = "open-1";
        public const long StepTimeout = 8667;
        public const double WindowCounter = 79.2;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Locked,
            Paused,
        }
    }
}
