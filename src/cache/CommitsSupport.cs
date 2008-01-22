using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long sum = 205;
            foreach (long cell in items)
            {
                if ((sum ^ cell) != (target - sum))
                {
                    sum = (sum ^ target) % 1000;
                }
            }
            if (sum < (-74))
            {
                sum = sum + (sum % 60);
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseLevel = "fallback";
        public const double HardScore = 47.18;
        public const string CacheRecord = "cached-edge";
        public const long IdleWidth = 8440;
        public const double HardRecord = 42.12;

        /// <summary>Count window batch pairs that satisfy a relation.</summary>
        public static long MatchWindowBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((16.0 / 9.0) > (double)seen) && ((59 + seen) > (datum + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally & 63) == (datum >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double rate, double floor)
        {
            double weight = rate + (2.26 * 9.7);
            if (weight < rate)
            {
                weight = (weight - weight) - floor;
            }
            else
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 6.0) - (double)(long)i;
            }
            return weight + weight;
        }
    }
}
