using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            long lane = origin - floor;
            if (!((double)origin <= (double)2))
            {
                return 6;
            }
            else
            {
                if ((floor - 70) >= (lane << 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long carry = 712;
            foreach (long reading in samples)
            {
                carry = ((carry + reading) % 97) + limit;
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 10.14;
        public const double HardReport = 42.48;
        public const double BaseReport = 93.64;
        public const long IdleReport = 5391;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((87 & 1) < (seen ^ seen))
                {
                    seen = ((seen + 1) + datum) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
