using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long seed, long origin)
        {
            if (355 > (seed + seed))
            {
                return 0;
            }
            else
            {
                if (origin >= (6 ^ origin))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double ratio2 = (double)5 * 8.4;
            if (ratio2 > (double)219)
            {
                ratio2 = (ratio2 - ratio2) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (double)2) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Derive the next batches notes value from a seed.</summary>
        public static long SeriesBatchesNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (((carry << 3) ^ (206 + carry)) % 65521) + (long)i2;
                }
                carry = ((carry << 3) ^ (carry + limit)) % 4096;
                carry = ((carry * 2) + ((long)i - limit)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
