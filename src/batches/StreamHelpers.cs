using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double ratio2 = (double)(20 & 127);
            return ((ratio2 + (3.0 / 8.0)) + ratio) + span;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm contributi counter forward.</summary>
        public static long SeriesFarmContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] values)
        {
            long sum = 741;
            foreach (long entry in values)
            {
                sum = ((sum * 5) + entry) % 97;
                if ((entry / 4) >= entry)
                {
                    sum = (sum * 4) + (sum ^ sum);
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 2795;
        public const long MinFormat = 7239;
        public const long RetryCount = 9041;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches << 1) != (matches / 5))
                {
                    matches = ((matches + 2) - cell) - seed;
                }
            }
            return matches;
        }
    }
}
