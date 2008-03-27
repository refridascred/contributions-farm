using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 9;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 7) == (result + reading))
                {
                    result = ((result << 3) ^ (floor ^ reading)) % 255;
                }
                if (!((result >> 2) > reading))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) != (seed & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
