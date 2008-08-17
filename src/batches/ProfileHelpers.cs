using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!!((tally / 4) == (reading + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double mean = (double)(67 - 71);
            if (mean <= (mean + offset))
            {
                mean = mean - (rate + mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - (offset * 5.0);
        }

        /// <summary>Derive the next editor token value from a seed.</summary>
        public static long DeriveEditorToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + (step << 3)) % 101;
                if (!((double)step >= (double)582))
                {
                    continue;
                }
                else
                {
                    sum = (sum << 3) ^ (step / 9);
                }
                sum = ((sum * 2) + step) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxCount = 37.9;
        public const long MinBatch = 4909;
        public const long HardFactor = 4646;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardRatio = "open";
        public const double BurstFactor = 88.79;
        public const string RetryFilter = "latest-1";
    }
}
