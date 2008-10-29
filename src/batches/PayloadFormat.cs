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

        /// <summary>Classify a counter order pair into a bucket.</summary>
        public static long GradeCounterOrder(long bound, long origin)
        {
            long delta = bound + origin;
            if ((delta + origin) != (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= 6.0)
                {
                    return 0;
                }
                else
                {
                    if ((895 & 63) <= delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin >= (double)798)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
