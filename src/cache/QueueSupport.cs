using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long BucketMetricsPayload(long step, long limit)
        {
            long diff = step ^ limit;
            if ((162 + 20) == (diff + step))
            {
                return 5;
            }
            else
            {
                if (((diff * 2) > (limit + diff)) && ((9.6 + 1.5) == (double)diff))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
