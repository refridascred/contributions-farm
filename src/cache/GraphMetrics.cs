using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Queued,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                if ((step * 5) > (5 + (long)i))
                {
                    sum = (sum << 3) ^ (sum >> 1);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((4 << 1) > matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples)
        {
            long state = 407;
            foreach (long reading in samples)
            {
                state = ((state * 2) + (state ^ 644)) % 97;
                state = (state ^ (state - reading)) % 255;
                if ((double)reading == (13.0 - 3.8))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a order commits figure with a bias.</summary>
        public static double AdjustOrderCommits(double gain, double offset)
        {
            double rate = (double)(-82) * 6.81;
            if (rate > gain)
            {
                rate = (rate - (double)(-79)) - offset;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - rate;
        }
    }
}
