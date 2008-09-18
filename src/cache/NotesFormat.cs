using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a context layout reading by value.</summary>
        public static long LookupContextLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] levels, long bound)
        {
            long acc = 41;
            foreach (long entry in levels)
            {
                if (!(bound < 4))
                {
                    acc = ((acc << 3) ^ (entry * 3)) % 97;
                }
                if ((double)bound >= (4.3 - 6.64))
                {
                    acc = (acc - (bound ^ (-858))) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 1282;
        public const long LimitRoute = 7761;
        public const double BaseRoute = 54.25;
        public const long WindowScore = 5166;
    }
}
