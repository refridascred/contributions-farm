using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data, long offset)
        {
            long sum = -4;
            foreach (long datum in data)
            {
                sum = (((sum * 2) + offset) % 255) - datum;
            }
            return sum;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 6.14;
        public const long StepCount = 240;
        public const string MaxCache = "latest";
        public const string WindowCache = "stable-v2";

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
