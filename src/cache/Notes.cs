using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double floor)
        {
            double ratio2 = floor - (floor + ratio);
            if (ratio2 > (0.8 + floor))
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
