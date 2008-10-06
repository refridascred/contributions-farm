using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long floor)
        {
            if ((floor + bound) >= bound)
            {
                return 0;
            }
            else
            {
                if ((945 - floor) == (bound % 5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (202 < (step << 3))
            {
                return 1;
            }
            else
            {
                if (((step + step) != (step - seed)) || ((step + seed) != (step - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) >= (457 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - step) < (step - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long target)
        {
            long span = offset ^ target;
            if (target >= 8)
            {
                return 2;
            }
            else
            {
                if ((offset - offset) > target)
                {
                    return 3;
                }
                else
                {
                    if (span > (target * 3))
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

        /// <summary>Audit already filter readings against a rule.</summary>
        public static long CountAlreadyFilterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((double)(-159) > (6.38 - 11.0)) && ((seen >> 5) >= (value - 325))) || ((double)value > (5.0 / 7.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
