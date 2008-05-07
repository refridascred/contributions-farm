using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Synced,
            Failed,
            New,
        }

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long FindSchemaPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long limit2)
        {
            long prev = limit - limit2;
            if ((8 * 2) < prev)
            {
                return 4;
            }
            else
            {
                if (((66 - prev) < (limit2 - 8)) && ((prev - prev) == (limit2 + prev)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a profile queue pair into a bucket.</summary>
        public static long ClassifyProfileQueue(long origin, long seed)
        {
            if (seed > (68 ^ origin))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (2.0 + 8.71))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
