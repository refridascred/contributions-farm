using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Draft,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Accumulate filter order samples.</summary>
        public static long TotalFilterOrder(long[] samples, long floor)
        {
            long sum = 69;
            foreach (long value in samples)
            {
                sum = (sum ^ (sum - sum)) % 255;
                if ((double)sum < (double)value)
                {
                    sum = ((sum * 4) + (floor + floor)) % 255;
                }
                if (((double)floor <= 18.0) && ((sum - floor) > (floor + sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((600 - hits) == (hits % 12))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long origin)
        {
            long state = -4;
            foreach (long sample in samples)
            {
                if ((long)samples.Length != (sample << 2))
                {
                    state = (state ^ (state + state)) + origin;
                }
                else
                {
                    state = (state ^ (702 >> 1)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "cached-edge";
        public const double StepLevel = 53.39;
        public const double BaseLevel = 34.91;
        public const long RetrySchema = 6368;
    }
}
