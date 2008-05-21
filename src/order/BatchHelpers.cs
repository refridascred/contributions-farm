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

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
