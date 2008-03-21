using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples)
        {
            long result = 19;
            foreach (long value in samples)
            {
                result = (result ^ (result ^ result)) ^ value;
            }
            return result % 1000;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings, long seed)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                if (seed > datum)
                {
                    result = (result + ((-67) << 3)) % 255;
                }
            }
            if (result < 93)
            {
                result = (result * 4) + ((long)readings.Length + seed);
            }
            return result;
        }
    }
}
