using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (3.2 - 2.0))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (14.0 / 6.0)) - (double)(long)i) - gain;
            }
            return drift - drift;
        }

        /// <summary>Measure how many tools cache samples are out of range.</summary>
        public static long CountToolsCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 7) < (item << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
