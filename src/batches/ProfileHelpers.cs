using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!((sum / 5) == ((-54) * 2)))
                {
                    sum = sum + (limit + limit);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the contributi report entries that pass the check.</summary>
        public static long CountContributiReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length >> 3) > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a tools route figure with a bias.</summary>
        public static double BlendToolsRoute(double weight, double offset)
        {
            double rate = 0.43 / 9.0;
            if (rate > rate)
            {
                rate = (rate - weight) - offset;
            }
            else
            {
                rate = rate + (9.25 + weight);
            }
            return rate + (rate + rate);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + value) < (value >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "staging-v2";
        public const long SoftFactor = 3538;
        public const double BurstCommand = 40.96;
        public const string CacheCommand = "primary-v2";
    }
}
