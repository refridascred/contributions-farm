using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total - (341 << 3)) % 1000) ^ (long)i2;
                }
                total = ((total << 3) ^ ((long)i << 1)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            if ((step - 12) < (84 % 2))
            {
                return 5;
            }
            else
            {
                if (!((step - origin) > (step + origin)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
