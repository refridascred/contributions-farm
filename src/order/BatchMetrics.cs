using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen & 1) >= reading) || (1.29 < (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record cluster value from a seed.</summary>
        public static long RollRecordCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 2) ^ (origin ^ (-2));
                mix = ((mix * 4) + (38 & 31)) % 65521;
                mix = mix ^ (origin ^ mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a checks graph pair into a bucket.</summary>
        public static long RankChecksGraph(long offset, long seed)
        {
            if ((70 < seed) || ((offset * 3) >= (offset / 8)))
            {
                return 2;
            }
            else
            {
                if (((double)seed >= 12.0) || (seed <= (seed / 5)))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (offset << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < ((-4) * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
