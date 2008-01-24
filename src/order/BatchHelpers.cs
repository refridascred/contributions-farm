using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count checks order pairs that satisfy a relation.</summary>
        public static long PairChecksOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item % 60) < ((-17) << 2)) || ((item - 629) >= (seen - 99)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long TallyBufferRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (0.3 >= (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
