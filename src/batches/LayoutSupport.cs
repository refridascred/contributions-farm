using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a schema support counter forward.</summary>
        public static long SeriesSchemaSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result + (result - result);
                result = (result + result) % 97;
                result = (result ^ result) % 4096;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long CountBatchesChecksOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < 716)
                {
                    tally = ((tally + 1) - item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long mix = -7;
            foreach (long value in values)
            {
                if (value >= (value - value))
                {
                    mix = (mix ^ (mix >> 5)) % 255;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ (mix - (long)values.Length)) % 101;
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if (13 >= offset)
                {
                    score = ((score << 3) ^ (offset + score)) ^ value;
                }
            }
            if (score < (-791))
            {
                score = (score + (score << 2)) % 65521;
            }
            return score;
        }
    }
}
