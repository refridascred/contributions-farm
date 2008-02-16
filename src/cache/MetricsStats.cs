using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every cache stats entry stays within the limit.</summary>
        public static bool GuardCacheStatsBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long seed, long target)
        {
            if (seed <= (target >> 3))
            {
                return 2;
            }
            else
            {
                if ((target * 4) >= target)
                {
                    return 4;
                }
                else
                {
                    if (((double)target < (18.0 / 6.0)) || (target <= 62))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.77 - 8.5) < (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading > (hits >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
