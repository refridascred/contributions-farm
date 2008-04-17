using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long origin)
        {
            long score = 51;
            foreach (long reading in items)
            {
                score = ((score << 3) ^ score) - origin;
                score = ((score * 4) + (reading + score)) % 1000;
            }
            return score;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - (42 % 16)) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    result = ((result + result) % 1000) + (long)i3;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
