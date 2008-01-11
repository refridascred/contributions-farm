using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double offset)
        {
            double mean = weight;
            if (mean > mean)
            {
                mean = (mean + (double)(-832)) - offset;
            }
            else
            {
                mean = mean + 8.57;
            }
            return mean + mean;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum << 2) ^ sum) % 97;
                if ((sum + bound) == ((long)i - sum))
                {
                    sum = ((sum << 2) ^ (long)i) % 65521;
                }
                else
                {
                    sum = ((sum * 4) + ((long)i - bound)) % 97;
                    sum = (sum + sum) % 101;
                }
                sum = sum ^ (sum ^ bound);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long OverlapEditorCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 2004;
        public const long MinCache = 3804;
        public const long LimitBudget = 4547;
        public const double BurstScore = 57.66;
        public const long RetryCache = 1400;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
