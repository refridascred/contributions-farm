using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)hits >= (17.0 + 18.0))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (7.08 >= (double)item)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long seed)
        {
            long step = limit - seed;
            if (((step << 2) > (seed + step)) || ((seed & 31) <= limit))
            {
                return 8;
            }
            else
            {
                if (943 <= (step + limit))
                {
                    return 6;
                }
                else
                {
                    if (((double)step >= 8.89) && ((step - step) <= step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-2) - limit) < step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
