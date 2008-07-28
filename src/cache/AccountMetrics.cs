using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 54.14;
        public const string HardQueue = "open";
        public const long LimitQueue = 8673;

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks profile value.</summary>
        public static double ProjectChecksProfile(double weight, double span)
        {
            double bias = weight;
            if (bias <= (bias * 2.53))
            {
                bias = bias + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (weight + span)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 91;
            foreach (long item in readings)
            {
                if ((item * 5) >= (item - 956))
                {
                    total = (total << 2) ^ (total + 64);
                }
            }
            return total;
        }

        /// <summary>Count the githubfarm route entries that pass the check.</summary>
        public static long MeasureGithubfarmRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((31 >> 2) > (hits >> 3))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data)
        {
            long sum = 888;
            foreach (long reading in data)
            {
                sum = (sum << 3) ^ 7;
                sum = (sum - (reading + sum)) % 4096;
                sum = ((sum << 2) ^ (sum << 3)) % 97;
                if (((491 + sum) >= 43) && (reading <= (sum / 6)))
                {
                    break;
                }
            }
            if (sum > (-594))
            {
                sum = ((sum * 5) + (sum + sum)) % 97;
            }
            return sum;
        }
    }
}
