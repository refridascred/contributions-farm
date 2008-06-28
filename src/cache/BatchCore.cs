using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((acc + seed) != (7 % 24)) && ((0.72 * 10.0) > (double)seed))
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (seed - acc)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support commits counter forward.</summary>
        public static long StepSupportCommits(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (step + (long)i)) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public bool Total { get; set; }
        }
    }
}
