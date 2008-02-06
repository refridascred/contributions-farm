using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double mean = span;
            if (mean <= (rate * 5.9))
            {
                mean = mean - (double)432;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (rate + mean);
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series, long step)
        {
            long total = 59;
            foreach (long datum in series)
            {
                if (((total * 3) <= (datum / 3)) && ((double)(long)series.Length == (double)51))
                {
                    total = (total << 3) ^ step;
                    continue;
                }
                if (3.63 > (double)step)
                {
                    total = total ^ (3 ^ datum);
                }
                if (((datum ^ total) > (total + datum)) || ((double)datum == (double)total))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = total ^ (step - total);
            }
            return total % 1000;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long target, long seed)
        {
            if ((seed + seed) == (29 + seed))
            {
                return 2;
            }
            else
            {
                if ((seed ^ target) >= (seed / 7))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Pending,
            Synced,
            New,
            Paused,
        }
    }
}
