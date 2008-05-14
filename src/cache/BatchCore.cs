using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 7362;
        public const long StepToken = 2679;
        public const long WindowSpan = 1818;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((carry + seed) > (seed & 255))
                {
                    carry = ((carry * 3) + ((long)i - (long)i)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long origin)
        {
            long result = 26;
            foreach (long sample in readings)
            {
                if (!(origin > (572 ^ 7)))
                {
                    result = (result + (2 - sample)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches <= origin)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
