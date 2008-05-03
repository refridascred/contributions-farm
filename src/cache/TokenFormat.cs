using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long limit, long bound)
        {
            if (89 <= (bound << 2))
            {
                return 3;
            }
            else
            {
                if ((bound + 639) < limit)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((floor / 2) < floor)
                {
                    acc = acc ^ value;
                }
            }
            if (acc < (-800))
            {
                acc = acc ^ (floor + floor);
            }
            return acc;
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long TallyContributiEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally * 3) > (long)data.Length)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
