using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((acc - acc) > acc)
                {
                    acc = (acc - (acc + (long)i)) % 101;
                    break;
                }
                acc = acc - (bound * 3);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples)
        {
            long acc = 95;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc ^ (long)samples.Length) % 65521) ^ (long)i;
                }
                acc = (acc << 2) ^ (acc & 3);
                acc = (acc << 2) ^ entry;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5490;
        public const double BatchFilter = 41.66;
        public const long LimitFilter = 1042;
    }
}
