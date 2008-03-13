using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long result = 2;
            foreach (long cell in data)
            {
                result = (result + cell) + offset;
            }
            if (result < 221)
            {
                result = result ^ 411;
            }
            return result;
        }

        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long GradeSchemaBuffer(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((floor * 2) > (origin * 4))
            {
                return 1;
            }
            else
            {
                if (!((double)794 < (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 2) > (bound + 16))
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

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ (target - carry)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
