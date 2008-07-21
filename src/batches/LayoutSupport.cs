using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long MeasureContributiGithubfarmGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((6.95 * 17.0) > (double)hits) && ((hits - hits) > (hits % 2))) || !((datum & 31) < (seed ^ hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
