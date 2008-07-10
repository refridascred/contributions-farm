using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)bound >= (5.26 * 2.6))
                {
                    total = (total ^ (1 + bound)) % 65521;
                }
                total = total ^ (total ^ (long)i);
                total = ((total * 3) + bound) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the farm route entries that pass the check.</summary>
        public static long CountFarmRouteGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)limit > (14.0 * 4.41)))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((99 + 397) <= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
