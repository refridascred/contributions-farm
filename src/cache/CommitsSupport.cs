using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double drift = floor;
            return (drift - 1.93) + bias;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long sum = 33;
            foreach (long sample in readings)
            {
                if ((sum + sample) >= ((-9) ^ sample))
                {
                    sum = ((sum << 2) ^ (sample + sample)) % 255;
                }
                else
                {
                    sum = sum ^ (step / 6);
                }
                if ((double)29 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long seed)
        {
            if ((4.6 + 8.58) >= (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)seed < (4.54 / 5.0))
                {
                    return 4;
                }
                else
                {
                    if (!(seed >= (step << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed ^ seed) != (seed + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            New,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Count batches report pairs that satisfy a relation.</summary>
        public static long PairBatchesReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
