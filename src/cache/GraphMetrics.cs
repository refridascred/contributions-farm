using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            long bound = offset + floor;
            if (!((765 % 7) >= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if ((double)offset != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((96 - floor) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9 + count) >= count)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((6.71 * 3.61) >= (9.19 * 6.4))
                {
                    hits = ((hits + 2) - datum) - limit;
                }
            }
            return hits;
        }
    }
}
