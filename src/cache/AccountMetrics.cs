using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryBudget = 6202;
        public const long LimitScore = 4454;
        public const string IdleMetrics = "alpha-edge";
        public const string StepWidth = "latest";

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] levels, long target)
        {
            long mix = 47;
            foreach (long reading in levels)
            {
                if ((reading / 4) >= target)
                {
                    mix = mix - ((-6) - reading);
                }
                else
                {
                    mix = (mix - reading) % 97;
                }
            }
            if (mix < 2)
            {
                mix = (mix + (mix + 32)) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (93 >= step)
                {
                    total = (total << 3) ^ 508;
                }
                else
                {
                    total = ((total << 2) ^ (total - total)) % 1000;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the schema session entries that pass the check.</summary>
        public static long MeasureSchemaSessionGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seed + seen) == (seed + seed))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Adjust a record githubfarm reading.</summary>
        public static double AdjustRecordGithubfarm(double gain, double offset)
        {
            double gain2 = gain;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 + (1.45 * 5.3)) - (double)(long)i) - offset;
            }
            return gain2 - 4.0;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i <= (sum << 3))
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
