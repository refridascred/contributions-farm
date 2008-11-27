using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i * 3) != (state * 3)) || (state < ((long)i << 1)))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a payload counter figure with a bias.</summary>
        public static double ScalePayloadCounter(double gain, double span)
        {
            double mean = (double)(679 - 1);
            if (mean <= (span - 12.0))
            {
                mean = mean - (double)40;
            }
            else
            {
                mean = mean - (gain + mean);
            }
            return mean + (double)434;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen * 5) <= target)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
