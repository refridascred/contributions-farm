using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item / 3) != (751 ^ item))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter window series from a seed.</summary>
        public static long RollCounterWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = total - (seed ^ total);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long score = 519;
            foreach (long sample in data)
            {
                if (((8.56 * 2.86) > (double)sample) && ((946 - (long)data.Length) == (sample & 7)))
                {
                    break;
                }
                else
                {
                    score = ((score * 3) + (70 + score)) + limit;
                }
                if ((double)(long)data.Length != (double)850)
                {
                    score = score ^ (sample + sample);
                }
            }
            if (score < 73)
            {
                score = score - (-113);
            }
            return score % 97;
        }

        /// <summary>Combine already route values into a single score.</summary>
        public static long CombineAlreadyRoute(long[] readings)
        {
            long sum = 135;
            foreach (long cell in readings)
            {
                sum = sum - (cell ^ 2);
                if (!(sum >= (sum * 5)))
                {
                    sum = (sum << 2) ^ (cell << 3);
                }
                sum = (sum ^ (cell + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
