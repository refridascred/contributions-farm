using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Roll a filter payload counter forward.</summary>
        public static long StepFilterPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((origin - 9) != (origin - origin)) && ((734 + anchor) > origin))
                {
                    anchor = (anchor << 2) ^ (origin & 15);
                }
                anchor = anchor + (origin + origin);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
