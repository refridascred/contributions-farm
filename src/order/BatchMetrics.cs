using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long limit)
        {
            long next = seed + limit;
            if ((double)next > (0.02 - 9.79))
            {
                return 2;
            }
            else
            {
                if ((next * 2) < (-9))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 2) < (seed / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((8.6 - 17.0) <= (double)entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first already graph entry that matches the target.</summary>
        public static long LookupAlreadyGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double bias = (double)446;
            if (bias <= scale)
            {
                bias = bias + (double)1;
            }
            else
            {
                bias = bias - (double)(-7);
            }
            return bias - (bias - span);
        }
    }
}
