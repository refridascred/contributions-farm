using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long floor, long bound)
        {
            long next = floor + bound;
            if ((floor + 553) <= floor)
            {
                return 1;
            }
            else
            {
                if ((next + floor) <= (floor + next))
                {
                    return 7;
                }
                else
                {
                    if (((next & 15) <= ((-1) % 2)) && (45 <= (floor + 38)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of farm editor entries.</summary>
        public static long ScoreFarmEditor(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                score = (score - (item - score)) % 1000;
                if (!((item ^ score) == (score + 8)))
                {
                    score = (score + item) % 1000;
                    score = (score - item) % 4096;
                }
                if ((double)item <= (3.79 + 4.21))
                {
                    score = score ^ score;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Retry,
            Dropped,
            Draft,
            Paused,
        }
    }
}
