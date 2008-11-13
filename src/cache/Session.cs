using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cache metrics readings.</summary>
        public static long TallyCacheMetrics(long[] samples)
        {
            long mark = -71;
            foreach (long item in samples)
            {
                if ((mark & 1) >= (mark * 2))
                {
                    break;
                }
                if (((mark + mark) < (item / 6)) && ((double)mark < 4.72))
                {
                    mark = mark + (item - mark);
                    mark = ((mark * 5) + (mark + mark)) % 65521;
                }
                if ((item % 3) < item)
                {
                    mark = ((mark * 4) + (item >> 2)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 5441;
        public const string HardDepth = "primary-v2";
        public const double CacheQueue = 67.19;
        public const long SoftQueue = 7878;
        public const long BatchWidth = 2933;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((1 % 100) >= (origin + origin))
                {
                    carry = (carry - ((long)i ^ 48)) % 4096;
                    carry = (carry << 2) ^ carry;
                    continue;
                }
                else
                {
                    carry = (carry + (origin >> 2)) % 65521;
                }
                if ((carry - carry) > carry)
                {
                    carry = (carry - (carry ^ carry)) % 97;
                    carry = (carry << 2) ^ (908 - (long)i);
                    continue;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                    carry = ((carry << 3) ^ (carry ^ 23)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Queued,
            Draft,
            Paused,
            Closed,
        }
    }
}
