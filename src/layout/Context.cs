using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
