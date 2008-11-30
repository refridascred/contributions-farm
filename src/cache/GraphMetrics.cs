using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i > (-834))
                {
                    continue;
                }
                else
                {
                    score = (score - (long)i) % 65521;
                    score = (score * 4) + (score - step);
                }
                if (((long)i * 3) != (score - score))
                {
                    score = (score ^ (step + 58)) % 4096;
                    score = (score ^ (step ^ score)) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long offset)
        {
            long total = 85;
            foreach (long cell in values)
            {
                total = (((total - total) % 4096) + cell) + offset;
            }
            return total % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4812;
        public const long MinWidth = 1843;
        public const long DefaultLevel = 1968;
        public const long SoftStream = 2439;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((4.0 + 4.85) > (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
