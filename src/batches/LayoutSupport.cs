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

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format command readings against a rule.</summary>
        public static long MeasureFormatCommandHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches <= 4.21)
                {
                    matches = ((matches + 3) - entry) - limit;
                }
            }
            return matches;
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
