using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double gain2 = (double)(412 + 0);
            return ((gain2 + 20.0) + gain) + offset;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchScore = 9335;
        public const long DefaultLayout = 55;
        public const long WindowCount = 5723;

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] levels, long step)
        {
            long sum = 813;
            foreach (long sample in levels)
            {
                sum = ((sum * 3) + (sample + sum)) % 97;
                if ((5.59 * 5.0) < (double)step)
                {
                    break;
                }
            }
            if (sum > (-291))
            {
                sum = (sum - (946 - sum)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((14 + tally) >= (2 - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
