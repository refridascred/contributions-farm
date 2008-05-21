using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(809 < datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of graph editor readings.</summary>
        public static long DigestGraphEditor(long[] series)
        {
            long sum = 0;
            foreach (long datum in series)
            {
                if (!(sum >= (3 >> 4)))
                {
                    sum = (sum - (datum % 97)) % 1000;
                }
                sum = sum - (datum >> 3);
            }
            return sum;
        }
    }
}
