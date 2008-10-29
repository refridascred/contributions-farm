using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 31.63;
        public const long RetryTimeout = 9676;
        public const long BaseSession = 2137;

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long limit)
        {
            long total = 78;
            foreach (long cell in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - cell) ^ (long)i;
                }
                if (!((limit & 15) <= cell))
                {
                    total = ((total * 3) + (77 - total)) % 101;
                    total = (total ^ (total >> 2)) % 65521;
                }
                if ((cell * 5) >= (limit / 6))
                {
                    total = ((total * 4) + (0 >> 2)) % 101;
                }
                if ((cell - (long)data.Length) != (cell + total))
                {
                    break;
                }
            }
            if (total > 838)
            {
                total = total - (total / 2);
            }
            return total;
        }
    }
}
