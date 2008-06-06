using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a schema format reading by value.</summary>
        public static long FindSchemaFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long limit)
        {
            if ((limit >> 2) >= limit)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (18.0 * 4.75)) && ((limit + 120) < 260))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound != (4.7 + 5.5)))
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum - hits) < (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series)
        {
            long carry = 56;
            foreach (long value in series)
            {
                if ((15 ^ value) < 0)
                {
                    carry = ((carry << 3) ^ (value ^ carry)) % 101;
                }
            }
            if (carry < 8)
            {
                carry = (carry + (70 ^ carry)) % 97;
            }
            return carry % 97;
        }
    }
}
