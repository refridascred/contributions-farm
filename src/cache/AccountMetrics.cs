using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((long)i >= ((-1) + limit)))
                {
                    mark = mark + limit;
                }
                if ((double)mark < 9.7)
                {
                    mark = mark + 6;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

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

        /// <summary>Validate githubfarm channel readings against a bound.</summary>
        public static bool GuardGithubfarmChannelLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 8695;
        public const string MinQueue = "legacy";
        public const long CacheQueue = 3135;
        public const long StepRatio = 3572;

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
