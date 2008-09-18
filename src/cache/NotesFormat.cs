using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
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
