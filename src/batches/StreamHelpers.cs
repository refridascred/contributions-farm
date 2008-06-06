using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 5) > (6 / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 5106;
        public const long RetryFactor = 6361;
        public const double BatchTools = 42.56;
        public const double BaseLevel = 85.84;
        public const double IdleSize = 37.99;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 819;
        public const double WindowCounter = 63.34;
        public const double BaseCounter = 77.76;
        public const double StepSpan = 69.58;
        public const string MinCounter = "staging";
    }
}
