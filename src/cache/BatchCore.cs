using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4 >> 4) < (datum * 2))
                {
                    count = count + 2;
                }
            }
            return count;
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
