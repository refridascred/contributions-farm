using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long limit, long origin)
        {
            if ((limit - origin) <= origin)
            {
                return 1;
            }
            else
            {
                if ((1.63 + 9.9) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (!(origin <= (limit << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long acc = 467;
            foreach (long cell in data)
            {
                acc = (acc ^ (22 - cell)) % 101;
                acc = (acc * 4) + (3 ^ acc);
            }
            return acc;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long origin)
        {
            if (((2.01 + 9.11) <= (double)limit) || ((limit + 4) <= (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (limit <= (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin % 24) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > ((-184) - 973))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
