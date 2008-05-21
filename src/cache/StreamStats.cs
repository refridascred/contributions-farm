using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long sum = 17;
            foreach (long cell in readings)
            {
                sum = ((sum << 2) ^ sum) % 101;
                if ((double)cell >= 0.3)
                {
                    sum = (sum - 872) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (7 + 88)) % 97;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Count the order filter entries that pass the check.</summary>
        public static long CountOrderFilterMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((-858) ^ offset) <= 1) || (datum >= (count - offset)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit checks commits readings against a rule.</summary>
        public static long MeasureChecksCommitsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches == (1.1 - 6.52))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double scale = floor - (weight + weight);
            if (scale <= (double)31)
            {
                scale = scale - (double)8;
            }
            return scale - scale;
        }
    }
}
