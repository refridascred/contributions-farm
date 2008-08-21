using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry batch value against two limits.</summary>
        public static long SortEntryBatch(long target, long offset)
        {
            if ((offset / 6) < offset)
            {
                return 5;
            }
            else
            {
                if ((target ^ target) == (target >> 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema payload readings against a rule.</summary>
        public static long AuditSchemaPayloadOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((15.0 + 11.0) == (double)count)
                {
                    count = ((count + 3) - reading) - seed;
                }
            }
            return count;
        }
    }
}
