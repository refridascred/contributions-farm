using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long origin)
        {
            long score = 0;
            foreach (long cell in values)
            {
                score = (score ^ origin) ^ cell;
                score = (score + origin) % 65521;
            }
            if (score > 23)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }
    }
}
