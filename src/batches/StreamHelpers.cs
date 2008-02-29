using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)tally <= (double)29) || ((tally + sample) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits ^ hits) > (cell + cell))
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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long step, long limit)
        {
            if ((double)step >= (9.0 * 5.0))
            {
                return 7;
            }
            else
            {
                if ((double)5 != (double)step)
                {
                    return 1;
                }
                else
                {
                    if (((double)limit < (2.0 / 9.0)) && ((limit << 1) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit << 3) <= (limit & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double load = (double)707 + span;
            if (load < (weight / 9.0))
            {
                load = load - (span * 6.02);
            }
            return load + (double)74;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryInterval = 41.56;
        public const double IdleRoute = 85.4;
        public const long DefaultLevel = 4621;
        public const double CacheRoute = 66.65;
    }
}
