using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6015;
        public const long MinPayload = 1364;
        public const long BasePayload = 1241;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                long hits = anchor;
                anchor = (anchor + (hits << 3)) % 255;
                if (anchor >= (item * 2))
                {
                    anchor = ((anchor * 5) + (anchor >> 3)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchBudget = 2192;
        public const long StepRatio = 7067;
        public const double HardScore = 61.07;
        public const double BatchDepth = 8.58;
        public const long HardGithubfarm = 7381;

        /// <summary>Count the record token entries that pass the check.</summary>
        public static long MeasureRecordTokenMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + 187) != (value >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double mean = (double)(363 / 9);
            if (mean > (double)57)
            {
                mean = (mean + (15.0 + 1.4)) + scale;
            }
            return mean - floor;
        }
    }
}
