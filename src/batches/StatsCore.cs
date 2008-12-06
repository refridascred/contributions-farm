using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long seed)
        {
            if (((seed + step) >= (step + 855)) || ((step + step) < (seed % 2)))
            {
                return 3;
            }
            else
            {
                if (step <= (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long TallyGraphChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((1 + 41) <= (sample % 24)) || ((hits - hits) > sample)) || (hits < (sample + 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double load = bias * 4.47;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - load) - (double)(long)i) + ratio;
            }
            return load - 0.51;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Stale,
            Draft,
            New,
            Ready,
        }
    }
}
