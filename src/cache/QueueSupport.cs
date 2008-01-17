using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum << 2) ^ (seed + sum)) - (long)i2;
                }
                sum = ((sum * 5) + (seed + seed)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine queue window values into a single score.</summary>
        public static long FoldQueueWindow(long[] series, long floor)
        {
            long acc = 4;
            foreach (long sample in series)
            {
                acc = ((acc + (acc ^ 57)) + sample) - floor;
            }
            if (acc < 955)
            {
                acc = acc + (acc >> 4);
            }
            return acc % 1000;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
