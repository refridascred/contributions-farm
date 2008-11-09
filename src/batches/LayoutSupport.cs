using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long carry = 616;
            foreach (long datum in series)
            {
                carry = ((carry << 2) ^ (carry % 97)) % 97;
                if ((datum << 1) == (datum & 127))
                {
                    break;
                }
            }
            if (carry < (-7))
            {
                carry = carry - (69 - carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of checks graph readings.</summary>
        public static long CompareChecksGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftWidth = 683;
        public const long MaxInterval = 3861;
        public const long HardCluster = 326;
        public const long LimitCluster = 2995;
        public const long MaxWidth = 9616;

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long floor)
        {
            if ((double)floor > (double)(-9))
            {
                return 6;
            }
            else
            {
                if ((13.0 / 3.0) != (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor - seed) <= (seed << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((5.1 / 3.0) < (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)origin == (3.88 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) == (75 - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin == (10.0 / 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
