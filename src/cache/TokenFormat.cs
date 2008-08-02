using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count editor payload pairs that satisfy a relation.</summary>
        public static long OverlapEditorPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSize = 3035;
        public const string MinWidth = "stable";
        public const string BaseSession = "local";

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long bound)
        {
            long mix = 687;
            foreach (long cell in readings)
            {
                mix = ((((mix * 2) + mix) % 65521) - cell) - bound;
            }
            return mix;
        }
    }
}
