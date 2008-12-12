using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Ready,
            Closed,
            Retry,
            Synced,
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

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
