using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long bound)
        {
            long edge = origin - bound;
            if (edge > origin)
            {
                return 1;
            }
            else
            {
                if (origin <= (origin << 1))
                {
                    return 2;
                }
                else
                {
                    if ((edge >= (bound >> 4)) && ((4.0 / 7.0) < (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "staging";
        public const long StepTimeout = 1001;
        public const string MinFactor = "local-edge";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits > reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
