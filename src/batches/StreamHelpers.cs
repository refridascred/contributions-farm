using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the payload batches series from a seed.</summary>
        public static long DerivePayloadBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (total ^ total)) % 1000;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double load = weight;
            return load - span;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long offset)
        {
            long cur = bound - offset;
            if ((4.81 / 8.0) <= (double)cur)
            {
                return 1;
            }
            else
            {
                if ((offset / 5) >= (cur ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound / 8) < (cur ^ cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (bound ^ bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Active,
            Synced,
            New,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 819;
        public const double WindowCounter = 63.34;
        public const double BaseCounter = 77.76;
        public const double StepSpan = 69.58;
        public const string MinCounter = "staging";
    }
}
