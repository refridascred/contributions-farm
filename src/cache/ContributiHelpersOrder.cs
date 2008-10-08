using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values, long limit)
        {
            long result = -39;
            foreach (long item in values)
            {
                result = ((result + ((long)values.Length ^ limit)) % 1000) ^ item;
                result = ((result * 3) + limit) % 97;
            }
            return result % 4096;
        }

        /// <summary>Roll a contributi batches counter forward.</summary>
        public static long RollContributiBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)origin <= (double)(long)i))
                {
                    total = total - (total + total);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 5851;
        public const long MinSpan = 1201;
        public const long DefaultContext = 8280;
    }
}
