using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long bound)
        {
            long total = 59;
            foreach (long sample in values)
            {
                if (!((sample >> 5) < 29))
                {
                    total = (total - (bound - sample)) % 1000;
                }
                total = total ^ 8;
                total = total - (bound + bound);
            }
            return total % 1000;
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
