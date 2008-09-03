using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long seed, long seed2)
        {
            long offset = seed - seed2;
            if (((seed2 + offset) <= (offset + offset)) || ((seed >> 2) != (offset - 74)))
            {
                return 7;
            }
            else
            {
                if ((double)offset > (1.8 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((seed << 3) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((15.0 <= (double)hits) || (((double)entry == (double)target) && ((double)entry != (4.66 / 2.0))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
