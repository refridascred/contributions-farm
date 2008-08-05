using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long seed, long target)
        {
            if (seed > (1 * 2))
            {
                return 2;
            }
            else
            {
                if ((target * 4) < (89 + target))
                {
                    return 4;
                }
                else
                {
                    if (seed <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)target < (double)30))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] readings, long floor)
        {
            long carry = 744;
            foreach (long sample in readings)
            {
                carry = (((carry * 5) + (floor + floor)) % 97) - sample;
                carry = (carry << 3) ^ ((-9) + floor);
            }
            if (carry < (-408))
            {
                carry = (carry << 3) ^ 52;
            }
            return carry % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (hits >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double drift = 3.39;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - weight) + (double)(long)i) - floor;
            }
            return drift + drift;
        }
    }
}
