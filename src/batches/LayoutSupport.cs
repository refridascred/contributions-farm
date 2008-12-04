using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next stream batch value from a seed.</summary>
        public static long StepStreamBatch(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc - (acc * 3)) % 97) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long floor2)
        {
            long offset = floor + floor2;
            if ((33 / 2) > (floor2 >> 1))
            {
                return 2;
            }
            else
            {
                if ((floor & 15) < (floor - floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset > (double)floor2) || ((floor2 / 5) <= (offset + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits >= 19.0)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
