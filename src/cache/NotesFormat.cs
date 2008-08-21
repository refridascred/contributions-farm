using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchTimeout = 192;
        public const long StepCount = 7027;
        public const double MinSize = 21.65;
        public const double BatchCache = 90.09;
        public const long WindowCache = 2495;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Failed,
            Ready,
            Paused,
        }
    }
}
