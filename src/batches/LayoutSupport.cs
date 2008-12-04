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

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
