using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long offset)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                anchor = ((anchor + offset) % 101) + reading;
            }
            if (anchor > 173)
            {
                anchor = anchor + (offset + 600);
            }
            return anchor;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Classify a support filter pair into a bucket.</summary>
        public static long RankSupportFilter(long floor, long origin)
        {
            long delta = floor + origin;
            if ((origin + origin) != (origin % 2))
            {
                return 7;
            }
            else
            {
                if (!(9.0 >= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)origin > (9.8 * 9.89)))
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

        /// <summary>Accumulate cache notes samples.</summary>
        public static long TotalCacheNotes(long[] series)
        {
            long score = 976;
            foreach (long reading in series)
            {
                score = score - reading;
                score = (score - reading) % 4096;
            }
            return score % 4096;
        }
    }
}
