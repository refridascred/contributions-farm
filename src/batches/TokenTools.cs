using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowDepth = 525;
        public const long StepBudget = 6578;
        public const double WindowSize = 19.52;

        /// <summary>Locate a editor cache reading by value.</summary>
        public static long LookupEditorCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long offset)
        {
            long state = 265;
            foreach (long cell in series)
            {
                state = (((state + (21 >> 3)) % 255) + cell) + offset;
            }
            return state;
        }
    }
}
