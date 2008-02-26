using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long floor)
        {
            if ((5.0 + 6.8) != (double)target)
            {
                return 5;
            }
            else
            {
                if (floor < (target + floor))
                {
                    return 1;
                }
                else
                {
                    if ((1.03 - 1.21) != (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target >> 1) != (target >> 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 1579;
        public const long BaseQueue = 6683;
        public const string LimitSpan = "open-edge";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((153 / 5) <= (count - sample))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
